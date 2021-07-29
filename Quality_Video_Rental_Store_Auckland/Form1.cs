using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quality_Video_Rental_Store_Auckland
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseModels databaseModels = new DatabaseModels();
        DatabaseLogics databaseLogics = new DatabaseLogics();
        
        int selectedId;

        // add new customer
        private void add_Ncusto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(customer_name.Text) && !string.IsNullOrEmpty(customer_contact.Text)  
                    && !string.IsNullOrEmpty(customer_address.Text) && !string.IsNullOrEmpty(age_textbox.Text) 
                    && !string.IsNullOrEmpty(male_female.Text) && !string.IsNullOrEmpty(identification_textbox.Text) )
                {
                    databaseModels.CstName = customer_name.Text;
                    databaseModels.CstContact = customer_contact.Text;
                    databaseModels.CstAddress = customer_address.Text;
                    databaseModels.CstAge = age_textbox.Text;
                    databaseModels.CstGender = male_female.Text;
                    databaseModels.CstIdentification = identification_textbox.Text;

                    string query = "Insert into tdCustomers values('" + databaseModels.CstName + "'," +
                        "'" + databaseModels.CstContact + "','" + databaseModels.CstAddress + "'," +
                        "'" + databaseModels.CstAge + "','" + databaseModels.CstGender + "','" + databaseModels.CstIdentification + "')";
                    
                    databaseLogics.DbChanges(query);
                    customer_address.Text = "";
                    customer_contact.Text = "";
                    customer_name.Text = "";
                    age_textbox.Text = "";
                    male_female.Text = "";
                    identification_textbox.Text = "";

                    MessageBox.Show("Customer is added, thank you");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check, all the inputs are required");
            }
        }
        private void update_Ncusto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(pkcustomer.Text) && !string.IsNullOrEmpty(customer_name.Text) && !string.IsNullOrEmpty(customer_contact.Text)
                        && !string.IsNullOrEmpty(customer_address.Text) && !string.IsNullOrEmpty(age_textbox.Text)
                        && !string.IsNullOrEmpty(male_female.Text) && !string.IsNullOrEmpty(identification_textbox.Text))
                    {
                    databaseModels.CstId = Convert.ToInt32(pkcustomer.Text);
                    databaseModels.CstName = customer_name.Text;
                    databaseModels.CstContact = customer_contact.Text;
                    databaseModels.CstAddress = customer_address.Text;
                    databaseModels.CstAge = age_textbox.Text;
                    databaseModels.CstGender = male_female.Text;
                    databaseModels.CstIdentification = identification_textbox.Text;

                    string qry = "update tdCustomers set CstName='" + databaseModels.CstName + "',CstContact='" + databaseModels.CstContact + "',CstAddress='" + databaseModels.CstAddress + "',CstAge='" + databaseModels.CstAge + "',CstGender='" + databaseModels.CstGender + "',CstIdentification='" + databaseModels.CstIdentification + "' where CstId=" + databaseModels.CstId + "";
                    
                    databaseLogics.DbChanges(qry);
                    pkcustomer.Text = "";
                    customer_address.Text = "";
                    customer_contact.Text = "";
                    customer_name.Text = "";
                    age_textbox.Text = "";
                    male_female.Text = "";
                    identification_textbox.Text = "";
                    MessageBox.Show("Customer is updated, thank you");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check, all the inputs are required");
            }
        }
        private void delete_Ncusto_Click(object sender, EventArgs e)
        {
            try
            {
                if (pkcustomer.Text != "")
                {
                    databaseModels.CstId = Convert.ToInt32(pkcustomer.Text);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure to delete Customer", "Confirm Customer ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        string qry = "delete from tdCustomers where CstId=" + databaseModels.CstId + "";
                        databaseLogics.DbChanges(qry);

                        pkcustomer.Text = "";
                        customer_address.Text = "";
                        customer_contact.Text = "";
                        customer_name.Text = "";
                        age_textbox.Text = "";
                        male_female.Text = "";
                        identification_textbox.Text = "";
                        age_textbox.Text = "";
                        MessageBox.Show("Customer is deleted");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Customer is not valid");
            }
        }
        // new video store to database

        private void add_NVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(video_title.Text) && !string.IsNullOrEmpty(video_ratting.Text) 
                    && !string.IsNullOrEmpty(video_year.Text)
                        && !string.IsNullOrEmpty(video_cost.Text) && !string.IsNullOrEmpty(video_copies.Text)
                        && !string.IsNullOrEmpty(video_plot.Text) && !string.IsNullOrEmpty(video_genre.Text))
                {
                    databaseModels.VdTitle = video_title.Text;
                    databaseModels.VdRating = video_ratting.Text;
                    databaseModels.VdYear = video_year.Text;
                    databaseModels.VdCost = video_cost.Text;
                    databaseModels.VdNumberOfCopies = video_copies.Text;
                    databaseModels.VdPlot = video_plot.Text;
                    databaseModels.VdGenre = video_genre.Text;

                    string query = "Insert into tdVideos(VdTitle,VdRating,VdYear,VdCost,VdNumberOfCopies,VdPlot,VdGenre) values('" + databaseModels.VdTitle + "'," +
                        "'" + databaseModels.VdRating + "','" + databaseModels.VdYear + "'," +
                        "'" + databaseModels.VdCost + "','" + databaseModels.VdNumberOfCopies + "','" + databaseModels.VdPlot + "','" + databaseModels.VdGenre + "')";

                    databaseLogics.DbChanges(query);
                    pkmovie.Text = "";
                    video_title.Text = "";
                    video_ratting.Text = "";
                    video_year.Text = "0";
                    video_cost.Text = "";
                    video_copies.Text = "";
                    video_plot.Text = "";
                    video_genre.Text = "";
                    MessageBox.Show("Video is Updated, thank you");
                }
                else
                {
                    MessageBox.Show("Please check, all the inputs are required");
                }

            }
            catch (Exception ex)
            {             
                MessageBox.Show("Please check, all the inputs are required");
            }
        }

        // delete vidio from database
        private void delete_NVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (pkmovie.Text != "")
                {

                    databaseModels.VdId = Convert.ToInt32(pkmovie.Text);

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure to delete Movie", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        string qry = "Delete from tdVideos where VdId=" + databaseModels.VdId + "";
                        databaseLogics.DbChanges(qry);
                        pkmovie.Text = "";
                        video_title.Text = "";
                        video_ratting.Text = "";
                        video_year.Text = "0";
                        video_cost.Text = "";
                        video_copies.Text = "";
                        video_plot.Text = "";
                        video_genre.Text = "";
                        MessageBox.Show("Video is Deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Video is not Invalid");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Video is not Invalid");
            }

        }
        // update video 

        private void update_Video_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(pkmovie.Text) && !string.IsNullOrEmpty(video_title.Text) && !string.IsNullOrEmpty(video_ratting.Text)
                    && !string.IsNullOrEmpty(video_year.Text)
                        && !string.IsNullOrEmpty(video_cost.Text) && !string.IsNullOrEmpty(video_copies.Text)
                        && !string.IsNullOrEmpty(video_plot.Text) && !string.IsNullOrEmpty(video_genre.Text))
                {
                    databaseModels.VdId = Convert.ToInt32(pkmovie.Text);
                    databaseModels.VdTitle = video_title.Text;
                    databaseModels.VdRating = video_ratting.Text;
                    databaseModels.VdYear = video_year.Text;
                    databaseModels.VdCost = video_cost.Text;
                    databaseModels.VdNumberOfCopies = video_copies.Text;
                    databaseModels.VdPlot = video_plot.Text;
                    databaseModels.VdGenre = video_genre.Text;


                    string qry = "Update tdVideos set VdTitle='" + databaseModels.VdTitle + "',VdRating='" + databaseModels.VdRating + "',VdYear=" + databaseModels.VdYear + ",VdCost=" + databaseModels.VdCost + ",VdNumberOfCopies=" + databaseModels.VdNumberOfCopies + ",VdPlot='" + databaseModels.VdPlot + "',VdGenre='" + databaseModels.VdGenre + "' where VdId=" + databaseModels.VdId + "";
                    databaseLogics.DbChanges(qry);
                    pkmovie.Text = "";
                    video_title.Text = "";
                    video_ratting.Text = "";
                    video_year.Text = "0";
                    video_cost.Text = "";
                    video_copies.Text = "";
                    video_plot.Text = "";
                    video_genre.Text = "";
                    MessageBox.Show("Video is updated, thank you");
                }
                else
                {
                    MessageBox.Show("Please check, all the inputs are required");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check, all the inputs are required");
            }
        }
        // issue movie

        private void issue_Nmovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (pkcustomer.Text != "" && pkmovie.Text != "")
                {
                    databaseModels.CstId = Convert.ToInt32(pkcustomer.Text);
                    databaseModels.VdId = Convert.ToInt32(pkmovie.Text);
                    databaseModels.RtIssueDate = dateTimePicker1.Text;
                    databaseModels.RtReturnDate = "Issued";

                    string qry = "Insert into tdRentals values(" + databaseModels.CstId + "," + databaseModels.VdId + ",'" + databaseModels.RtIssueDate + "','" + databaseModels.RtReturnDate + "')";
                    databaseLogics.DbChanges(qry);

                    pkmovie.Text = "";
                    pkcustomer.Text = "";
                    MessageBox.Show("Video is issued, thank you");
                }
                else
                {
                    MessageBox.Show("Please check, all the inputs are required");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please check, all the inputs are required");
            }
        }

        // delete movie
        private void delete_Nmovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (pkcustomer.Text != "" && pkmovie.Text != "")
                {

                    databaseModels.CstId = Convert.ToInt32(pkcustomer.Text);
                    databaseModels.VdId = Convert.ToInt32(pkmovie.Text);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure to delete the booked video ", "Confirm Video ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        string qry = "Delete from tdRentals where CstId=" + databaseModels.CstId + " and VdId=" + databaseModels.VdId + "";
                        databaseLogics.DbChanges(qry);

                        pkmovie.Text = "";
                        pkcustomer.Text = "";
                        MessageBox.Show("Video is deleted, thank you");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Video");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Video");
            }


        }

        // return movie
        private void return_Nmovie_Click(object sender, EventArgs e)
        {
            try
            {
                if ( pkcustomer.Text != "" && pkmovie.Text != "")
                {
                    databaseModels.CstId = Convert.ToInt32(pkcustomer.Text);
                    databaseModels.VdId = Convert.ToInt32(pkmovie.Text);
                    databaseModels.RtIssueDate = dateTimePicker1.Text;
                    databaseModels.RtReturnDate = dateTimePicker2.Text;
                    DateTime date = Convert.ToDateTime(dateTimePicker1.Text);
                    string days = (DateTime.Now - date).TotalDays.ToString();

                    string qry = "update  tdRentals set RtIssueDate='" + databaseModels.RtIssueDate + "',RtReturnDate='" + databaseModels.RtReturnDate + "' where CstId=" + databaseModels.CstId + " and VdId=" + databaseModels.VdId + "";
                    databaseLogics.DbChanges(qry);

                    DataTable dataTable = databaseLogics.SaveChanges("Select * from tdVideos where VdId=" + Convert.ToInt32(pkmovie.Text) + "");
                    int cost = Convert.ToInt32(dataTable.Rows[0]["VdCost"].ToString());

                    pkmovie.Text = "";
                    pkcustomer.Text = "";
                    MessageBox.Show("issue video is returned, your generated bill is $" + (Convert.ToDouble(days) * cost));
                }
                else
                {
                    MessageBox.Show("Please check, all the inputs are required");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check, all the inputs are required");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (selectedId)
            {
                case 1:

                    pkcustomer.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    customer_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    customer_contact.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    customer_address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    age_textbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    male_female.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    identification_textbox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    break;

                case 2:
                    databaseModels.RtId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    pkcustomer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    pkmovie.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    var IsDate = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
                    if(IsDate != "Issued")
                    dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    break;

                case 3:
                    pkmovie.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    video_title.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    video_ratting.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    video_year.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    video_cost.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    video_copies.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    video_plot.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    video_genre.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    break;
            }
            selectedId = 0;
        }

        // best movie show
        private void best_movie_Click(object sender, EventArgs e)
        {
            DataTable dataTable = databaseLogics.SaveChanges("select * from tdVideos");
            int rowIndex = 0;
            string Title = "";
            while (rowIndex < dataTable.Rows.Count)
            {
                DataTable Rental = databaseLogics.SaveChanges("select * from tdRentals where VdId=" + Convert.ToInt32(dataTable.Rows[rowIndex]["VdId"]) + "");

                int length = 0;
                if (Rental.Rows.Count > length)
                {
                    Title = dataTable.Rows[rowIndex]["VdTitle"].ToString();
                    length = Rental.Rows.Count;
                }
                rowIndex++;
            }
            MessageBox.Show(Title + " is the best Video, Good Luck");
        }
        private void best_customer_Click(object sender, EventArgs e)
        {
            DataTable customers = databaseLogics.SaveChanges("select * from tdCustomers");

            int rowIndex = 0;
            string CustomerName = "";

            while (rowIndex < customers.Rows.Count)
            {
                DataTable dataTablelRental = databaseLogics.SaveChanges("select * from tdRentals where CstId=" + Convert.ToInt32(customers.Rows[rowIndex]["CstId"]) + "");

                int length = 0;
                if (dataTablelRental.Rows.Count > length)
                {
                    CustomerName = customers.Rows[rowIndex]["CstName"].ToString();
                    length = dataTablelRental.Rows.Count;
                }
                rowIndex++;
            }
            MessageBox.Show(CustomerName + " is best Customer, Good Luck");
        }
        private void video_year_TextChanged_1(object sender, EventArgs e)
        {
                int year = Convert.ToInt32(video_year.Text.ToString());
                DateTime dateTime = DateTime.Now;

                int currentYear = dateTime.Year;

                if ((currentYear - year) > 5)
                {
                    video_cost.Text = "2";
                }
                else
                {
                    video_cost.Text = "5";
                }
        }
        private void customer_record_show_Click(object sender, EventArgs e)
        {
            selectedId = 1;
            DataTable customers = databaseLogics.SaveChanges("select * from tdCustomers");
            dataGridView1.DataSource = customers;
        }
        private void rental_record_show_Click(object sender, EventArgs e)
        {
            selectedId = 2;
            DataTable rentals = databaseLogics.SaveChanges("select * from tdRentals");
            dataGridView1.DataSource = rentals;
        }
        private void video_record_show_Click(object sender, EventArgs e)
        {
            selectedId = 3;
            DataTable videos = databaseLogics.SaveChanges("select * from tdVideos");
            dataGridView1.DataSource = videos;
        }
    }
}
