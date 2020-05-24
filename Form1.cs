using System.Drawing;
using System.Windows.Forms;

namespace Bi_Directional_Drag_n_Drop
{
    public partial class Form1 : Form
    {
        int indexFirst = 0;
        int indexSecond = 0;

        public Form1()
        {
            InitializeComponent();

            string[] items = new string[] { "Thing1", "Thing2", "Thing3", "Thing4", "Thing5" };
            lstFirst.Items.AddRange( items );
        }



        /****************************************************************************************************************
            #######                                         ##               #####                                     
            #       ### #####   ####  #####                   ##            #     # ######  ####   ####  #    # #####  
            #        #  #    # #        #                       ##          #       #      #    # #    # ##   # #    # 
            #####    #  #    #  ####    #            #####        #          #####  #####  #      #    # # #  # #    # 
            #        #  #####       #   #                       ##                # #      #      #    # #  # # #    # 
            #        #  #   #  #    #   #                     ##            #     # #      #    # #    # #   ## #    # 
            #       ### #    #  ####    #                   ##               #####  ######  ####   ####  #    # #####  
         ****************************************************************************************************************/

        private void lstFirst_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lstFirst = sender as ListBox;

            indexFirst = lstFirst.IndexFromPoint(e.X, e.Y);
            indexSecond = -1;

            if (indexFirst >= 0 && e.Button == MouseButtons.Left)
                lstFirst.DoDragDrop(lstFirst.Items[indexFirst].ToString(), DragDropEffects.Move);
        }

        private void lstSecond_DragEnter(object sender, DragEventArgs e)
        {
            if (indexFirst >= 0 &&
                e.Data.GetDataPresent(typeof(System.String)))   // If the data being dragged is a string
                e.Effect = DragDropEffects.Move;                // Allow it to move
            else                                                // If it is not a string
                e.Effect = DragDropEffects.None;                // Do not allow it
        }

        private void lstSecond_DragDrop(object sender, DragEventArgs e)
        {
            var ndxSecond = lstSecond.IndexFromPoint(lstSecond.PointToClient(new Point(e.X, e.Y)) );

            if (ndxSecond == -1)
                lstSecond.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            else
                lstSecond.Items.Insert(ndxSecond, e.Data.GetData(typeof(System.String)).ToString());

            if (indexFirst >= 0)
                lstFirst.Items.RemoveAt(indexFirst);
        }

        /*************************************************************************************************/



        /****************************************************************************************************************
             #####                                                     ##              #######                         
            #     # ######  ####   ####  #    # #####                    ##            #       ### #####   ####  ##### 
            #       #      #    # #    # ##   # #    #                     ##          #        #  #    # #        #   
             #####  #####  #      #    # # #  # #    #          #####        #         #####    #  #    #  ####    #   
                  # #      #      #    # #  # # #    #                     ##          #        #  #####       #   #   
            #     # #      #    # #    # #   ## #    #                   ##            #        #  #   #  #    #   #   
             #####  ######  ####   ####  #    # #####                  ##              #       ### #    #  ####    #   
         ****************************************************************************************************************/

        private void lstSecond_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lstSecond = sender as ListBox;

            indexSecond = lstSecond.IndexFromPoint(e.X, e.Y);
            indexFirst = -1;

            if (indexSecond >= 0 && e.Button == MouseButtons.Left)
                lstSecond.DoDragDrop(lstSecond.Items[indexSecond].ToString(), DragDropEffects.Move);
        }

        private void lstFirst_DragEnter(object sender, DragEventArgs e)
        {
            if (indexSecond >= 0 &&
                e.Data.GetDataPresent(typeof(System.String)))   // If the data being dragged is a string
                e.Effect = DragDropEffects.Move;                // Allow it to move
            else                                                // If it is not a string
                e.Effect = DragDropEffects.None;                // Do not allow it
        }

        private void lstFirst_DragDrop(object sender, DragEventArgs e)
        {
            var ndxFirst = lstFirst.IndexFromPoint(lstFirst.PointToClient(new Point(e.X, e.Y)));

            if (ndxFirst == -1)
                lstFirst.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            else
                lstFirst.Items.Insert(ndxFirst, e.Data.GetData(typeof(System.String)).ToString());

            if (indexSecond >= 0)
                lstSecond.Items.RemoveAt(indexSecond);
        }

        /*************************************************************************************************/
    }
}
