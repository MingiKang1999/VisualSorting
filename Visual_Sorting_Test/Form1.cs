using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Author: Mingi Kang
/// 
/// File Date: 12/23/2020
/// 
/// This program is made to visual display the speed and process of three different sorting algorithms
/// Bubble sorting, Selection sorting, and Quicksorting
/// 
/// The runtime of the algorithm is delayed to display the graphics and show greater difference between the algorithms
/// </summary>
namespace Visual_Sorting_Test
{
    /// <summary>
    /// Store all the components used for the program
    /// </summary>
    public partial class sortingForm : Form
    {
        private Graphics g; //Encapsulates a GDI+ drawing surface
        private SolidBrush b; //Brushes are used to fill graphics shapes
        private Color c = Color.LightBlue; //Represents a color, initially set to black
        private List<int> data = new List<int>() { 30, 40, 40, 150, 10, 140, 20, 130, 90, 80, 70, 100, 50, 60, 120, 80, 110, 160 }; //List used to compare the sorting algorithms
        private int count = 0;

        /// <summary>
        /// Initialize all background components
        /// </summary>
        public sortingForm()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(249, 228, 183);
            this.Paint += new PaintEventHandler(sortingForm_Paint);  //Registers the Paint event handler
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void runExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Run the selection sorting
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void runSelectionMenu_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            Selection(data);
        }
        /// <summary>
        /// Run the bubble sorting
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void runBubbleMenu_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            Bubble(data);
        }
        /// <summary>
        /// Run the quicksorting
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void runQuickMenu_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            Quick(data, 0, data.Count - 1);
        }
        /// <summary>
        /// Selection sorting algorithm
        /// </summary>
        /// <param name="data">List of integers to be sorted</param>
        private async void Selection(List<int> data)
        {
            //Disable all the clickable
            selectionButton.Visible = false;
            bubbleButton.Visible = false;
            quickButton.Visible = false;
            exitButton.Visible = false;
            runMenu.Enabled = false;
            var watch = new System.Diagnostics.Stopwatch(); //Create a new stopwatch
            watch.Start(); //Start the timer
            int min; //Current minimum value
            for (int i = 0; i < data.Count; i++)
            {
                min = i;
                for(int n = i + 1; n < data.Count; n++)
                {
                    if (data[n] < data[min]) //If the next value is smaller than the current minimum value swap
                    {
                        min = n;
                    }
                }
                await Task.Delay(500); //Add a delay to the program for the visual graphics
                g.FillRectangle(new SolidBrush(Color.FromArgb(249, 228, 183)), 0, 0, 1000, 1000); //Erase the graph
                Graph(data); //Draw a new graph

                Swap(i, min, data); //Swap the index of the data
            }
            watch.Stop(); //End timer
            Reset(); //Enable all the clickable
            this.data = new List<int>() { 30, 40, 40, 150, 10, 140, 20, 130, 90, 80, 70, 100, 50, 60, 120, 80, 110, 160 }; //Reset the list to original value
            resultLabel.Text = $"Total Runtime: {watch.ElapsedMilliseconds} ms"; //Display total runtime
        }
        /// <summary>
        /// Bubble sorting algorithm
        /// </summary>
        /// <param name="data">List of integers to be sorted</param>
        private async void Bubble(List<int> data)
        {
            //Disable all the clickable
            selectionButton.Visible = false;
            bubbleButton.Visible = false;
            quickButton.Visible = false;
            exitButton.Visible = false;
            runMenu.Enabled = false;
            var watch = new System.Diagnostics.Stopwatch(); //Create a new stopwatch
            watch.Start(); //Start the timer
            g.FillRectangle(new SolidBrush(Color.FromArgb(249, 228, 183)), 0, 0, 1000, 1000); //Erase the graph
            Graph(data); //Draw a new graph
            for (int i = 0; i <= data.Count - 2; i++)
            {
                for (int n = 0; n <= data.Count - 2; n++)
                {
                    if (data[n] > data[n + 1]) //If the next value is smaller than the current value swap
                    {
                        await Task.Delay(500); //Add a delay to the program for the visual graphics
                        Swap(n + 1, n, data); //Swap the index of the data
                        g.FillRectangle(new SolidBrush(Color.FromArgb(249, 228, 183)), 0, 0, 1000, 1000); //Erase the graph
                        Graph(data); //Draw a new graph
                    }
                }
            }
            watch.Stop(); //End timer
            Reset(); //Enable all the clickable
            this.data = new List<int>() { 30, 40, 40, 150, 10, 140, 20, 130, 90, 80, 70, 100, 50, 60, 120, 80, 110, 160 }; //Reset the list to original value
            resultLabel.Text = $"Total Runtime: {watch.ElapsedMilliseconds} ms"; //Display total runtime
        }
        /// <summary>
        /// Quick sorting algorithm
        /// </summary>
        /// <param name="data">List of integers to be sorted</param>
        /// <param name="left">Left side of the list</param>
        /// <param name="right">Right side of the list</param>
        private async void Quick(List<int> data, int left, int right)
        {
            //Disable all the clickable
            selectionButton.Visible = false;
            bubbleButton.Visible = false;
            quickButton.Visible = false;
            exitButton.Visible = false;
            var watch = new System.Diagnostics.Stopwatch(); //Start the timer
            watch.Start(); //Start the timer
            if (left < right) //Sort the left side of the list
            {
                this.count++;
                int pivot = await Partition(data, left, right);

                if (pivot > 1) //Check the pivot
                {
                    Quick(data, left, pivot - 1);
                }
                if (pivot + 1 < right) //Check the pivot for right side of the list
                {
                    Quick(data, pivot + 1, right);
                }
                if (this.count == 10)
                {
                    watch.Stop(); //End timer
                    Reset(); //Enable all the clickable
                    this.data = new List<int>() { 30, 40, 40, 150, 10, 140, 20, 130, 90, 80, 70, 100, 50, 60, 120, 80, 110, 160 }; //Reset the list to original value
                    resultLabel.Text = $"Total Runtime: {watch.ElapsedMilliseconds} ms"; //Display total runtime
                }
            }
        }
        /// <summary>
        /// Swap the first value with the second value
        /// </summary>
        /// <param name="first">First Index</param>
        /// <param name="second">Second Index</param>
        /// <param name="data">List of integers to be sorted</param>
        private static void Swap(int first, int second, List<int> data)
        {
            int temp = data[first];
            data[first] = data[second];
            data[second] = temp;
        }
        /// <summary>
        /// Checks for the pivot point
        /// </summary>
        /// <param name="data">List of integers to be sorted</param>
        /// <param name="left">Left side index</param>
        /// <param name="right">Right side index</param>
        /// <returns></returns>
        private async Task<int> Partition(List<int> data, int left, int right)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(249, 228, 183)), 0, 0, 1000, 1000); //Erase the graph
            Graph(data); //Draw a new graph
            int pivot = data[left]; //Start from left side of the list
            while (true)
            {
                while (data[left] < pivot)
                {
                    left++;
                }

                while (data[right] > pivot) 
                {
                    right--;
                }

                if (left < right) //Pivot
                {
                    if (data[left] == data[right])
                    {
                        return right;
                    }
                    await Task.Delay(500); //Add a delay to the program for the visual graphics
                    g.FillRectangle(new SolidBrush(Color.FromArgb(249, 228, 183)), 0, 0, 1000, 1000); //Erase the graph
                    Graph(data); //Draw a new graph
                    Swap(left, right, data); //Swap the index of the data
                }
                else
                {
                    return right;
                }
            }
        }
        /// <summary>
        /// Create paint variables
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e">Form initialized</param>
        private void sortingForm_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;                          //Get the Graphics object from the PaintEventArgs
            b = new SolidBrush(c);                   //Create a new brush using the current colour

            g = this.CreateGraphics();               //Create a graphics object
        }
        /// <summary>
        /// Draw the new graph
        /// </summary>
        /// <param name="data">List of integers to be sorted</param>
        private void Graph(List<int> data)
        {
            int x = 30; //Width of the bar
            int increase = 0;
            for (int i = 0; i < data.Count; i++)
            {
                g.FillRectangle(b, x + increase, 350 - data[i], 20, data[i]); //Create the bar
                increase = increase + 40; //Seperate the bar from one another
            }
        }
        /// <summary>
        /// Enable all the clickable objects
        /// </summary>
        public void Reset()
        {
            selectionButton.Visible = true;
            bubbleButton.Visible = true;
            quickButton.Visible = true;
            exitButton.Visible = true;
            runMenu.Enabled = true;
        }
        /// <summary>
        /// Start selection sorting
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void selectionButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            Selection(data);
        }
        /// <summary>
        /// Start bubble sorting
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">CLick</param>
        private void bubbleButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            Bubble(data);
        }
        /// <summary>
        /// Start quicksorting
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">CLick</param>
        private void quickButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            Quick(data, 0, data.Count - 1);
        }
    }
}
