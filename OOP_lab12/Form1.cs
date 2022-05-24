using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using FigureLibrary;

namespace OOP_lab12
{

    public partial class Form1 : Form
    {
        static Point topPoint = new Point();
        Point previousPoint = new Point(topPoint);
        bool mouseIsDown = false;
        bool isShiftDown = false;
        Shape previousFigure;
        Graphics g;
        ShapeList shapeList = new ShapeList();
        ShapeList tempList = new ShapeList();
        List<Shape> plugins;

        private System.Drawing.Point mousePos1;
        private System.Drawing.Point mousePos2;
        private DraggedFragment draggedFragment;

        public Form1()
        {
            InitializeComponent();
            g = DrawPanel.CreateGraphics();
            backToolStripMenuItem.Enabled = false;
            vToolStripMenuItem.Enabled = false;
        }

        public int GetRButtonIndex()
        {
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                if (((RadioButton)groupBox2.Controls[i]).Checked == true) { return i; }
            }
            return -1;
        }

        private void LoadPlugins(string path)
        {
            string[] pluginFiles = Directory.GetFiles(path, "*.dll");
            plugins = new List<Shape>();
            int x = 10,y=14;

            foreach (string pluginPath in pluginFiles)
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(pluginPath);
                    Type[] objType = assembly.GetTypes();
                    
                    foreach (var type in objType)
                    {
                        if (type.IsSubclassOf(typeof(Shape)))
                        {
                            var plugin = (Shape)Activator.CreateInstance(type);
                            plugins.Add(plugin);
                            RadioButton button = new RadioButton();
                            button.Location = new System.Drawing.Point(x, y);
                            button.Name = type.Name;
                            button.Text = (type.Name == "Adapter" ? "Star" : type.Name);
                            button.AutoSize = true;
                            groupBox2.Controls.Add(button);
                            x +=button.Width;
                        }
                    }
                    ((RadioButton)groupBox2.Controls[0]).Checked = true;

                }
                catch
                {
                    continue;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlugins(Application.StartupPath);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            DrawPanel.Width = this.Width - 40;
            DrawPanel.Height = this.Height - DrawPanel.Top - 50;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Black.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Black.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Gray.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Gray.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void Brown_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Brown.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Brown.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void White_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = White.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(White.BackColor);
                DrawPanel.Invalidate();
            }
        }

        List<Shape> getHighlightedFigures()
        {
            List<Shape> highlited = new List<Shape>();
            bool isInside;
            foreach(var shape in shapeList.shapeList)
            {
                isInside = true;
                for (int i = 0; i < shape.masX.Count; i++)
                {
                    if (!draggedFragment.Rect.Contains((int)shape.masX[i], (int)shape.masY[i]))
                    {
                        isInside = false;
                        break;
                    }
                }
                if (isInside) highlited.Add(shape);
            }
            return highlited;
        }

        List<Shape> highlighted = new List<Shape>();
        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (buttonHighlight.BackColor == ColorTranslator.FromHtml("#abcdef"))
            {
                if (draggedFragment != null && !draggedFragment.Rect.Contains(e.Location))
                {
                    //уничтожаем фрагмент
                    draggedFragment = null;
                    DrawPanel.Invalidate();
                }
                return;
            }
            topPoint.x = e.X;
            topPoint.y = e.Y;
            previousPoint.x = topPoint.x;
            previousPoint.y = topPoint.y;
            mouseIsDown = true;
            previousFigure = new Point(topPoint.x, topPoint.y);
        }

        public void ErasePrevious(Shape shape)
        {
            shape.setBorderColor(DrawPanel.BackColor);
            PanelDraw.draw(g, shape);
            shapeList.draw(g);
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (buttonHighlight.BackColor == ColorTranslator.FromHtml("#abcdef"))
            {
                if (e.Button == MouseButtons.Left)
                {
                    //юзер тянет фрагмент?
                    if (draggedFragment != null)
                    {
                        //сдвигаем фрагмент
                        draggedFragment.Location.Offset(e.Location.X - mousePos2.X, e.Location.Y - mousePos2.Y);
                        mousePos1 = e.Location;
                        if (highlighted.Count != 0)
                            foreach (var figure in highlighted)
                            {
                                figure.offset(e.Location.X - mousePos2.X, e.Location.Y - mousePos2.Y);
                            }
                    }
                    //сдвигаем выделенную область
                    mousePos2 = e.Location;
                    DrawPanel.Invalidate();
                }
                else
                {
                    mousePos1 = mousePos2 = e.Location;
                }
                return;
            }
                
            Point bottomPoint = new Point(e.X, e.Y);
            isShiftDown = Control.ModifierKeys == Keys.Shift;
            if (mouseIsDown)
            {
                ErasePrevious(previousFigure);
                int index = GetRButtonIndex();
                string str = ((RadioButton)groupBox2.Controls[index]).Name;
                //foreach(var plugin in plugins)
                //{
                //    if (plugin.ToString().Split(".")[plugin.ToString().Split(".").Length - 1] == str)
                //    {
                //        str = plugin.GetType().AssemblyQualifiedName;
                //        break;
                //    }
                //}
                FactoryShape shapeFactory = new FactoryShape();
                var shape = shapeFactory.GetShape(str);
                shape.MouseMove(topPoint.x, topPoint.y, bottomPoint.x, bottomPoint.y);
                shape.setBorderColor(panelColor.BackColor);
                PanelDraw.draw(g, shape);
                previousFigure = shape;
                previousPoint = bottomPoint;
            }
            
        }

        System.Drawing.Rectangle GetRect(System.Drawing.Point p1, System.Drawing.Point p2)
        {
            var x1 = Math.Min(p1.X, p2.X);
            var x2 = Math.Max(p1.X, p2.X);
            var y1 = Math.Min(p1.Y, p2.Y);
            var y2 = Math.Max(p1.Y, p2.Y);
            return new System.Drawing.Rectangle(x1, y1, x2 - x1, y2 - y1);
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (buttonHighlight.BackColor == ColorTranslator.FromHtml("#abcdef"))
            {
                //пользователь выделил фрагмент и отпустил мышь?
                if (mousePos1 != mousePos2)
                {
                    //создаем DraggedFragment
                    var rect = GetRect(mousePos1, mousePos2);
                    draggedFragment = new DraggedFragment() { SourceRect = rect, Location = rect.Location };
                    //g.FillRectangle(new SolidBrush(System.Drawing.Color.Transparent), draggedFragment.SourceRect);
                    highlighted = getHighlightedFigures();

                }
                else
                {
                    //пользователь сдвинул фрагмент и отпутил мышь?
                    if (draggedFragment != null)
                    {
                        //фиксируем изменения в исходном изображении
                        draggedFragment.Fix(g, DrawPanel.Width, DrawPanel.Height);
                        //уничтожаем фрагмент
                        draggedFragment = null;
                        mousePos1 = mousePos2 = e.Location;
                       
                    }
                }
                DrawPanel.Invalidate();
                return;
            }

            mouseIsDown = false;
            Point top = new Point(topPoint.x, topPoint.y);
            backToolStripMenuItem.Enabled = true;
            if (top.x == previousPoint.x && top.y == previousPoint.y)
            {
                Point point = new Point(top.x, top.y);
                point.setBorderColor(panelColor.BackColor);
                PanelDraw.draw(g, point);
                shapeList.add(point);
                return;
            }
            //int index = GetRButtonIndex();
            //string str = ((RadioButton)groupBox2.Controls[index]).Name;
            //foreach (var plugin in plugins)
            //{
            //    if (plugin.ToString().Split(".")[plugin.ToString().Split(".").Length - 1] == str)
            //    {
            //        str = plugin.ToString();
            //        break;
            //    }
            //}
            //var shape = (Shape)Activator.CreateInstance(Type.GetType(str));
            //shape.setBorderColor(panelColor.BackColor);
            shapeList.add(previousFigure);
            

        }
        ShapeList saved = new ShapeList();
        bool isControlPressed = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
                isShiftDown = true;
            isControlPressed = e.Control;
            if(buttonHighlight.BackColor == ColorTranslator.FromHtml("#abcdef") && isControlPressed && e.KeyCode == Keys.C)
            {
                foreach (var elem in highlighted)
                {
                    var clone = elem.Clone();
                    saved.add(clone);
                }
            }
            if (buttonHighlight.BackColor == ColorTranslator.FromHtml("#abcdef") && isControlPressed && e.KeyCode == Keys.V)
            {
                foreach (var elem in saved.shapeList)
                    shapeList.add(elem);
                shapeList.draw(g);
            }
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Yellow.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Yellow.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Orange.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Orange.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void Red_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Red.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Red.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void Green_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Green.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Green.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void Lime_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Lime.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Lime.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void SkyBlue_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = SkyBlue.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(SkyBlue.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Blue.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Blue.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void Teal_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Teal.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Teal.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Purple.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(Purple.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void LightPurple_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = LightPurple.BackColor;
            if (highlighted.Count != 0)
            {
                foreach (var figure in highlighted)
                    figure.setBorderColor(LightPurple.BackColor);
                DrawPanel.Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shapeList.removeAll();
            tempList.removeAll();
            SolidBrush brush = new SolidBrush(DrawPanel.BackColor);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, DrawPanel.Width, DrawPanel.Height);
            g.FillRectangle(brush, rect);
            backToolStripMenuItem.Enabled = false;
            vToolStripMenuItem.Enabled = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serializer.Serialize(shapeList);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serializer.Deserialize(ref shapeList);
            shapeList.draw(g);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempList.add(shapeList.getLast());
            shapeList.removeLast();
            SolidBrush brush = new SolidBrush(DrawPanel.BackColor);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, DrawPanel.Width, DrawPanel.Height);
            g.FillRectangle(brush, rect);
            shapeList.draw(g);
            vToolStripMenuItem.Enabled = true;
            if (shapeList.Count() == 0)
                backToolStripMenuItem.Enabled = false;
            else
                backToolStripMenuItem.Enabled = true;
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeList.add(tempList.getLast());
            tempList.removeLast();
            shapeList.draw(g);
            backToolStripMenuItem.Enabled = true;
            if (tempList.Count() == 0)
                vToolStripMenuItem.Enabled = false;
            else
                vToolStripMenuItem.Enabled = true;
        }

        private void buttonMark_Click(object sender, EventArgs e)
        {
            if (buttonHighlight.BackColor != ColorTranslator.FromHtml("#abcdef"))
            {
                DrawPanel.Cursor = Cursors.Cross; 
                buttonHighlight.BackColor = ColorTranslator.FromHtml("#abcdef");
            }
            else
            {
                DrawPanel.Cursor = Cursors.Default;
                buttonHighlight.BackColor = button1.BackColor;
                draggedFragment = null;
                highlighted.Clear();
                DrawPanel.Invalidate();
            }
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            //если есть сдвигаемый фрагмент
            if (draggedFragment != null)
            {
                //рисуем вырезанное белое место
                e.Graphics.SetClip(draggedFragment.SourceRect);
                e.Graphics.Clear(System.Drawing.Color.White);

                //рисуем сдвинутый фрагмент
                e.Graphics.SetClip(draggedFragment.Rect);
                e.Graphics.DrawImage(new Bitmap(DrawPanel.Width, DrawPanel.Height, g), draggedFragment.Location.X - draggedFragment.SourceRect.X, draggedFragment.Location.Y - draggedFragment.SourceRect.Y);

                //рисуем рамку
                e.Graphics.ResetClip();
                ControlPaint.DrawFocusRectangle(e.Graphics, draggedFragment.Rect);
            }
            else
            {
                //если выделена область
                if (mousePos1 != mousePos2)
                    ControlPaint.DrawFocusRectangle(e.Graphics, GetRect(mousePos1, mousePos2));//рисуем рамку
            }
            shapeList.draw(e.Graphics);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isControlPressed = !e.Control;
        }
    }
}
