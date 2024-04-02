using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Week12_lab_20_Gui_Premier
{
    public partial class Form1 : Form
    {
        //Declare a variable to store the premiers
        private Dictionary<string, Premier> premiers;

        public Form1()
        {
            
            InitializeComponent();

            // Bind the event handler to the SelectedValueChanged event of the ListBox
            lst.SelectedValueChanged += lst_SelectedValueChanged;

            this.Text = "Ontario's Premiers"; //Changing title

            // Call the method to initialize GUI components
            InitializeGui();
        }
        //method that will populate a Dictionary from a List 
        private void InitializeGui()
        {
            // Initialize the premiers dictionary containing strings
            premiers = new Dictionary<string, Premier>();

            //Obtain the list of premiers
            List<Premier> premierList = Premier.GetPremiers();

            //Populate the premiers dictionary and ListBox
            foreach (Premier premier in premierList)
            {
                //Generate key for the current premier
                string keyPremier = premier.GenerateKey();

                //Add the premier to the dictionary
                premiers.Add(keyPremier, premier);
            }

            //Populate the ListBox with the generated dictionary keys
            lst.DataSource = new List<string>(premiers.Keys);
        }

        //method to updateGUI based on key
        private void UpdateGui(string key)
        {
            if (premiers.ContainsKey(key)) //check if the dictionary contains the specified key
            {
                Premier premier = premiers[key];
                lblName.Text = premier.Name;  //set premier object's name to the text property of the Label 'Name'
                lblLife.Text = premier.Life;  //set premier object's life property to the text property of the Label 'Life'
                lblTerm.Text = $"{premier.Start} - {premier.End}"; //set premier object's term property to the text property of the Label 'Term'
                lblConstituent.Text = premier.Constituent;
                lblParty.Text = premier.Party;

                // Load and display premier image
                string imagePath = Path.Combine(Application.StartupPath, "images", $"{key}.jpg"); //combine the application startup path with a subdirectory named "images" and the file name formed by appending .jpg to the key.
                if (File.Exists(imagePath))
                {
                    pic.ImageLocation = imagePath; //sets the ImageLocation property of the PictureBox control named pic to the file path, causing the PictureBox to display the image.
                }
                else
                {
                    pic.Image = null; //clear picturebox when image file does not exist
                }
            }
        }

        //event handler when an item is selected in the Listbox
        private void lst_SelectedValueChanged(object sender, EventArgs e)
        {
                string currentselectedKey = lst.SelectedItem.ToString(); //retrieve currently selected item in the ListBox and convert into the string
                UpdateGui(currentselectedKey); //updateGUI using selected key
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
