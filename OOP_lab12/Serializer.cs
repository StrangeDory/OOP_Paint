using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using FigureLibrary;
using Microsoft.Build.Execution;
using System.Security.Cryptography;

namespace OOP_lab12
{
    class Serializer
    {
        static OpenFileDialog openDialog = new OpenFileDialog();
        static SaveFileDialog saveDialog = new SaveFileDialog();
        
        public static void Serialize(ShapeList list)
        {
            saveDialog.DefaultExt = ".txt";
            saveDialog.Filter = "TXT files (*.txt)|*txt";
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = saveDialog.FileName;
            try
            {
                writeObjects(list, fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Deserialize(ref ShapeList list)
        {
            openDialog.DefaultExt = ".txt";
            openDialog.Filter = "TXT files (*.txt)|*txt";
            if (list != null)
                list.removeAll();
            if (openDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openDialog.FileName;
            try
            {
                list = readObjeccts(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void writeObjects(ShapeList list, string fileName)
        {
            if (list.Count() == 0)
                File.WriteAllText(fileName, "null");
            else
            {
                List<string> text = new List<string>();
                foreach(var figure in list.shapeList)
                {
                    String header = figure.GetType().AssemblyQualifiedName + "&" + figure.getBorderColor().Name + "&" +
                        string.Join("-", figure.masX) + "|" + string.Join("-", figure.masY);
                    text.Add(header);
                }
                byte[] a = DES.DESEncrypt(String.Join("\n", text));
                File.WriteAllBytes(fileName, a);
            }
        }

        private static ShapeList readObjeccts(string fileName)
        {
            byte[] a = File.ReadAllBytes(fileName);
            string[] text = DES.DESDecrypt(a).Split("\n");
            ShapeList shapeList = new ShapeList();
            if (text[0] != "null")
            {
                foreach(var line in text)
                {
                    string[] figureInfo = line.Split('&');
                    var x = new List<float>(figureInfo[2].Split('|')[0].Split('-').Select(float.Parse));
                    var y = new List<float>(figureInfo[2].Split('|')[1].Split('-').Select(float.Parse));
                    
                    var shape = (Shape)Activator.CreateInstance(Type.GetType(figureInfo[0]));
                    shape.masX = x;
                    shape.masY = y;
                    shape.setBorderColor(Color.FromName(figureInfo[1]));
                    shapeList.add(shape);
                }
            }
            return shapeList;
        }
    }
}
