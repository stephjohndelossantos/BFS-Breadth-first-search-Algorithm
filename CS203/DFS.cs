using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CS203
{
    public partial class DFS : Form
    {
        //global variables        
        bool stopcreate;
        int[,] diagram; //serve as the adjacent matrix
        int countnodes;//counter
        String[] vertices;//nodes
        Graphics graph;

        public DFS()
        {
            InitializeComponent();
            setclear();
        }
        public void setclear()
        {
            //set the initialization of variables to clear
            graph = picgraph.CreateGraphics();
            stopcreate = false;
            diagram = new int[50, 50];
            vertices = new string[50];
            countnodes = 0;

        }

        private void btncreatenodes_Click(object sender, EventArgs e)
        {
            stopcreate = false;
        }
        private void setAdjacentMatrixToZero(int nodeCount)
        {
            for (int x = 0; x < nodeCount; x++)
            {
                for (int y = 0; y < nodeCount; y++)
                {
                    if (dataGridView1.Rows[x].Cells[y].Value == null)
                    {
                        dataGridView1.Rows[x].Cells[y].Value = 0;
                    }
                }
            }
        }
        private void setAdjacentMatrixToOne(int edge1, int edge2)
        {
            for (int x = 0; x < countnodes; x++)
            {
                for (int y = 0; y < countnodes; y++)
                {
                    if (edge1 == x && edge2 == y)
                    {
                        dataGridView1.Rows[edge1].Cells[edge2].Value = 1;
                        dataGridView1.Rows[edge2].Cells[edge1].Value = 1;
                    }
                }
            }
            /*dataGridView1.Rows[edge1].Cells[edge2].Value = 1;
            dataGridView1.Rows[edge2].Cells[edge1].Value = 1;*/
        }

        private void btnadjacentnodes_Click(object sender, EventArgs e)
        {
            try
            {
                if (stopcreate == true)
                {
                    //set or define the adjacent of two nodes
                    int edge1 = Convert.ToInt32(cmbEdge1.Text);
                    int edge2 = Convert.ToInt32(cmbEdge2.Text);

                    //split the coordinates of x, and y of the edges
                    string[] c1 = vertices[edge1].Split('-');
                    string[] c2 = vertices[edge2].Split('-');

                    //cast it to integer and store it to another variable
                    int xcoordinate1 = Convert.ToInt32(c1[0]);//coordinate of edge1
                    int ycoordinate1 = Convert.ToInt32(c1[1]);//coordinate of edge1

                    int xcoordinate2 = Convert.ToInt32(c2[0]);//coordinate of edge2
                    int ycoordinate2 = Convert.ToInt32(c2[1]);//coordinate of edge2

                    //after retrieving the x and y coordinate, we will draw a line
                    graph.DrawLine(new Pen(Brushes.Green, 2), (float)(xcoordinate1 + (35 / 2)),
                        (float)(ycoordinate1 + (35 / 2)), (float)(xcoordinate2 + (35 / 2)),
                        (float)(ycoordinate2 + (35 / 2)));

                    //calculate distance
                    double x = (double)(xcoordinate2 - xcoordinate1);
                    double y = (double)(ycoordinate2 - ycoordinate1);
                    double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                    int a = (int)(xcoordinate1 + xcoordinate2) / 2;
                    int b = (int)((ycoordinate1 + ycoordinate2) / 2) - 5;
                    graph.DrawString(Math.Round(d, 2).ToString(), new Font("Arial", 10), Brushes.Maroon, a, b);

                    //adjacent matrix(undirected graph - no arrows)
                    diagram[edge1, edge2] = Convert.ToInt32(d); // the same distance
                    diagram[edge2, edge1] = Convert.ToInt32(d);

                    //set adjacent matrix value to 1
                    setAdjacentMatrixToOne(edge1, edge2);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("ENTER VALID ADJACENT INPUTS!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void cmbEdge2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void colornodes(int node, Brush c)
        {
            String[] s = vertices[node].Split('-');

            int x = Convert.ToInt32(s[0]); // x coordinate to edge1
            int y = Convert.ToInt32(s[1]); // x coordinate to edge2

            Rectangle rect = new Rectangle(x, y, 35, 35);
            graph.FillEllipse(c, rect);
            graph.DrawString(node.ToString(), new Font("Arial", 12), Brushes.White, new PointF(x + 8, y + 8));
        }


        private void picgraph_click(object sender, EventArgs e)
        {

        }

        private void picgraph_MouseClick(object sender, MouseEventArgs e)
        {
            //when you click the mouse at the leftside
            if (e.Button == MouseButtons.Left && stopcreate != true)
            {
                Rectangle rect = new Rectangle((e.X) - (35 / 2), (e.Y) - (35 / 2), 35, 35);

                //define the locaiton of x and y coordinate and the size of the nodes that created
                graph.FillEllipse(Brushes.DarkBlue, rect);

                graph.DrawString(countnodes.ToString(), new Font("Arial", 10),
                    Brushes.White, ((e.X) - (35 / 2)) + 10, ((e.Y) - (35 / 2)) + 11);
                //the number that will appear base in the counter if the nodes that been

                vertices[countnodes] = ((e.X) - (35 / 2)) + "-" + ((e.Y) - (35 / 2));
                                
                //increment another node to draw in the datagridview
                                
                cmbEdge1.Items.Add(countnodes);
                cmbEdge2.Items.Add(countnodes);
                cmbSource.Items.Add(countnodes);
                cmbDestination.Items.Add(countnodes);
                countnodes++;

                dataGridView1.Columns.Add("", (countnodes - 1).ToString());
                dataGridView1.AutoResizeColumns();

                dataGridView1.Rows.Add();
                dataGridView1.Rows[countnodes - 1].HeaderCell.Value = (countnodes - 1).ToString();
                dataGridView1.AutoResizeRows();

                // add 0 value to the grid
                setAdjacentMatrixToZero(countnodes);

            }
            else
            {
                stopcreate = true;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to to delete everything?", "Delete Nodes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                // clears the pic graph
                picgraph.Image = null;
                // clears the gridview
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                // clears the combo boxes 
                cmbEdge1.Items.Clear();
                cmbEdge1.ResetText();
                cmbEdge1.DropDownHeight = 106;
                cmbEdge2.Items.Clear();
                cmbEdge2.ResetText();
                cmbEdge2.DropDownHeight = 106;
                cmbSource.Items.Clear();
                cmbSource.ResetText();
                cmbSource.DropDownHeight = 106;
                cmbDestination.Items.Clear();
                cmbDestination.ResetText();
                cmbDestination.DropDownHeight = 106;
                setclear();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog(); //Initialize or instantiate
            od.Filter = "Text Document(*.txt)|*.txt";// file extension            
            od.ValidateNames = true; // validation

            if (od.ShowDialog() == DialogResult.OK)
            {
                //clear everything
                setclear();
                cmbEdge1.Items.Clear();
                cmbEdge2.Items.Clear();
                cmbSource.Items.Clear();
                cmbDestination.Items.Clear();
                lblpath.Text = "The Traversal Path is : ";
                //label1.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                Graphics g = picgraph.CreateGraphics();
                g.Clear(Color.White);

                try
                {
                    String line = "";
                    StreamReader sr = new StreamReader(od.FileName);

                    while (sr.Peek() != -1)
                    {
                        cmbEdge1.Items.Add(countnodes);
                        cmbEdge2.Items.Add(countnodes);
                        cmbSource.Items.Add(countnodes);
                        cmbDestination.Items.Add(countnodes);

                        countnodes++;

                        dataGridView1.Columns.Add("", (countnodes - 1).ToString());
                        dataGridView1.AutoResizeColumns();
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[countnodes - 1].HeaderCell.Value = (countnodes - 1).ToString();
                        dataGridView1.AutoResizeRows();


                        line = sr.ReadLine();
                        String[] adjacent = line.Split('\t');
                        String[] nodes = adjacent[0].Split('-');
                        int node1 = Convert.ToInt32(nodes[0]);
                        int x1 = Convert.ToInt32(nodes[1]);
                        int y1 = Convert.ToInt32(nodes[2]);
                        vertices[node1] = x1 + "-" + y1;

                        Rectangle rect = new Rectangle(x1, y1, 35, 35);
                        g.FillEllipse(Brushes.Blue, rect);
                        g.DrawString(node1.ToString(), new Font("Arial", 12), Brushes.White, x1 + 8, y1 + 8);

                        for (int i = 1; i < adjacent.Length; i++)
                        {
                            nodes = adjacent[i].Split('-');
                            int node2 = Convert.ToInt32(nodes[0]);
                            int x2 = Convert.ToInt32(nodes[1]);
                            int y2 = Convert.ToInt32(nodes[2]);

                            vertices[node2] = x2 + "-" + y2;

                            rect = new Rectangle(x2, y2, 35, 35);
                            g.FillEllipse(Brushes.Blue, rect);
                            g.DrawString(node2.ToString(), new Font("Arial", 12), Brushes.White, x2 + 8, y2 + 8);
                            g.DrawLine(new Pen(Brushes.Green, 3), (float)(x1 + 12), (float)(y1 + 12),
                                (float)(x2 + 12), (float)(y2 + 12));

                            //calculate Distance
                            double x = (double)(x2 - x1);
                            double y = (double)(y2 - y1);
                            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                            int a = (int)(x1 + x2) / 2;
                            int b = ((int)(y1 + y2) / 2) - 5;
                            g.DrawString(Math.Round(d, 2).ToString(), new Font("Arial", 12),
                                Brushes.Maroon, a, b);

                            //adjacenct matrix 
                            diagram[node1, node2] = Convert.ToInt32(d);
                            diagram[node2, node1] = Convert.ToInt32(d);

                            setAdjacentMatrixToOne(node1, node2);
                        }
                        setAdjacentMatrixToZero(countnodes);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid File!");
                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog(); // initialize the Save Dialog
            sd.Filter = "Text Document(*.txt)|*.txt";  //this is the file extension


            if (sd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sd.FileName, true);
                String nodes = "";
                for (int i = 0; i < countnodes; i++)
                {
                    nodes = i + "-" + vertices[i];
                    for (int j = 0; j < countnodes; j++)
                    {
                        if (diagram[i, j] != 0)
                        {
                            nodes = nodes + "\t" + j + "-" + vertices[j];
                        }
                    }
                    sw.WriteLine(nodes);
                }
                MessageBox.Show("File Saved", "File");
                sw.Close();
            }
        }

        private void cmbEdge1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public void dfsTraversal()
        {
            try
            {
                int source = Convert.ToInt32(cmbSource.Text);
                int destination = Convert.ToInt32(cmbDestination.Text);

                Stack<int> stack = new Stack<int>();
                HashSet<int> visited = new HashSet<int>();

                colornodes(source, Brushes.DarkOrange);
                colornodes(destination, Brushes.Red);

                stack.Push(source); 
                Thread.Sleep(150);
                while (stack.Count != 0)    //loop if not empty
                {
                    int first = stack.Pop();   // Pop the top node from the stack
                    Thread.Sleep(500);
                    //color color
                    colornodes(first, Brushes.DarkGreen);
                    Application.DoEvents();
                    lblpath.Text += " " + first + " ";

                    if (!visited.Contains(first))     
                    {
                        visited.Add(first);
                        //lets loop for ouir neighbors of x
                        for (int i = 0; i < countnodes; i++) 
                        {
                            Thread.Sleep(150);
                            if (diagram[first, i] != 0)
                            {
                                if (!visited.Contains(i))   
                                {
                                    stack.Push(i);
                                }
                            }
                        }

                    }

                    if (first == destination)
                    {
                        MessageBox.Show("Traversal Finished!", "Traversal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("ENTER VALID TRAVERSAL INPUTS!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        

        private void btnTraversal_Click(object sender, EventArgs e)
        {
            lblpath.Text = "The Traversal Path is : ";
            dfsTraversal();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }






}
