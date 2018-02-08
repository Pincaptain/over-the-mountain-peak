using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Over_The_Mountains_Peak {
    public partial class BaseForm : Form {
        public BaseForm() {
            InitializeComponent();
            CustomInitializer();
        }
        
        /// <summary>
        /// Initializes custom parameters.
        /// </summary>
        private void CustomInitializer() {
            CategoryTree.Nodes.Add(new ViewNode() {
                Tag = new CategoryView("Global"),
                Text = "Global",
            });
        }

        /// <summary>
        /// Clears the current category tree deleting all the 
        /// added data.
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewToolMenu_Click(object sender, EventArgs e) {
            CategoryTree.Nodes.Clear();
            CategoryTitleTextBox.Text = String.Empty;
            DescriptionClearButton_Click(sender, e);
            DetailContentLabel.Text = String.Empty;
            DetailTitleLabel.Text = String.Empty;
            DetailImagePictureBox.BorderStyle = BorderStyle.None;
            DetailImagePictureBox.Image = null;
            DetailImageDescriptionLabel.Text = String.Empty;
            DetailAudioMediaPlayer.URL = String.Empty;
            DetailAudioMediaPlayer.Hide();

            CustomInitializer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolMenu_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog() {
                Filter = "JSON File (*.json)|*.json",
                FilterIndex = 1,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                Extension.TreeViewDeserialize(CategoryTree, openFileDialog.FileName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolMenu_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                Filter = "JSON File (*.json)|*.json",
                FilterIndex = 1,
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                Extension.TreeViewSerialize(CategoryTree, saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Closes the software once the "Quit" menu button
        /// was clicked.
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitToolMenu_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// Modifies what is displayed in the <see cref="TabControl"/> "View" once a
        /// category or a description is selected. If the selected option 
        /// is a category it will display a list of his children 
        /// descriptions and categories. Otherwise the selected description
        /// detail view will be displayed.
        /// </summary>
        /// 
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryTreeNode_Selected(object sender, EventArgs e) {
            object selected = CategoryTree.SelectedNode;
            View view = (View)((ViewNode)selected).Tag;

            if (selected == null || view.IsCategory()) {
                return;
            }

            DetailView selectedDetailView = (DetailView)view;

            Bitmap associatedImage = new Bitmap(selectedDetailView.DetailImagePath);
            DetailImagePictureBox.Image = associatedImage;
            DetailImagePictureBox.BorderStyle = BorderStyle.FixedSingle;
        
            DetailTitleLabel.Text = selectedDetailView.ViewName;
            DetailContentLabel.Text = selectedDetailView.DetailContent;
            DetailImageDescriptionLabel.Text = selectedDetailView.DetailImageDescription;

            DetailAudioMediaPlayer.Show();
            DetailAudioMediaPlayer.URL = selectedDetailView.DetailAudioDescription;
        }

        /// <summary>
        /// Adds a new category to the tree view on the right
        /// once the add category button was clicked.
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// <exception cref="AddToDescriptionException">
        /// Illegal action! Cannot add a new category to a description.
        /// </exception>
        private void CategoryAddButton_Click(object sender, EventArgs e) {
            if (CategoryTitleTextBox.Text.Equals(String.Empty))
                return;

            object selected = CategoryTree.SelectedNode;
            ViewNode node = new ViewNode() {
                Tag = new CategoryView(CategoryTitleTextBox.Text),
                Text = CategoryTitleTextBox.Text
            };

            if (selected == null) {
                CategoryTree.Nodes.Add(node);
            } else if (((View)((ViewNode)selected).Tag).IsCategory()) {
                CategoryTree.SelectedNode.Nodes.Add(node);
            } else {
                throw new AddToDescriptionException("Cannot add a new category to a description!");
            }

            CategoryTitleTextBox.Text = String.Empty;
        }

        /// <summary>
        /// Adds a new description to the tree view based
        /// on the information provided in the
        /// <see cref="ContentRichTextBox"/>,
        /// <see cref="DescriptionTitleTextBox"/>
        /// <see cref="ImagePathTextBox"/>
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// <exception cref="AddToDescriptionException">
        /// Illegal action! Cannot add a new category to a description.
        /// </exception>
        private void DescriptionAddButton_Click(object sender, EventArgs e) {
            if (DescriptionTitleTextBox.Text.Equals(String.Empty) ||
                DescriptionContentRichTextBox.Text.Equals(String.Empty) ||
                DescriptionImagePathTextBox.Text.Equals(String.Empty))
                return;

            object selected = CategoryTree.SelectedNode;
            ViewNode node = new ViewNode() {
                Tag = new DetailView(DescriptionTitleTextBox.Text,
                DescriptionContentRichTextBox.Text,
                DescriptionImagePathTextBox.Text,
                DescriptionImageDescriptionTextBox.Text,
                DescriptionAudioPathTextBox.Text),
                Text = DescriptionTitleTextBox.Text
            };

            if (selected == null) {
                CategoryTree.Nodes.Add(node);
            } else if (((View)((ViewNode)selected).Tag).IsCategory()) {
                CategoryTree.SelectedNode.Nodes.Add(node);
            } else {
                throw new AddToDescriptionException("Cannot add a new description to a description!");
            }

            DescriptionClearButton_Click(sender, e);
        }

        /// <summary>
        /// Clears the field and allows the user to re-enter
        /// the desired information.
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionClearButton_Click(object sender, EventArgs e) {
            DescriptionTitleTextBox.Text = String.Empty;
            DescriptionContentRichTextBox.Text = String.Empty;
            DescriptionImagePathTextBox.Text = String.Empty;
            DescriptionImageDescriptionTextBox.Text = String.Empty;
            DescriptionAudioPathTextBox.Text = String.Empty;
        }

        /// <summary>
        /// Opens a file browser and allows you to pick
        /// your image file. Once picked the image path is 
        /// stored in the <see cref="ImagePathTextBox"/>.
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionSelectImageButton_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog() {
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                Multiselect = false,
                Title = "Image Browser"
            };

            fileDialog.FileOk += new CancelEventHandler(delegate (object s, CancelEventArgs args) {
                string filePath = fileDialog.FileName;
                DescriptionImagePathTextBox.Text = filePath;
                DescriptionImageDescriptionTextBox.Text = Path.GetFileNameWithoutExtension(filePath);
            });

            fileDialog.ShowDialog();
        }
    }
}
