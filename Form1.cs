using System;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Person> people;
        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 peopleData = new Class1();
            people = peopleData.People;
            dataGridView1.DataSource = people;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // If the user clicks 'Save' (DialogResult.OK) in Form2
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // Create a new Person from the input in Form2
                Person newPerson = new Person
                {
                    Name = form2.PersonName,
                    ID = form2.PersonID
                };

                // Add the new person to the list
                people.Add(newPerson);

                // Refresh the DataGridView to show the updated list
                dataGridView1.DataSource = null;  // Reset DataSource to force refresh
                dataGridView1.DataSource = people;
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int ID { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
