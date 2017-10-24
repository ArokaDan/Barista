using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

//using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
    private CoffeeMaker kaffemaskin = new CoffeeMaker(); 
        
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = " Välkommen välj din drink";
            //kaffemaskin = new CoffeeMaker(); 
        }
       // CoffeeMaker kaffemaskin = new CoffeeMaker(); 
       // int check = 0;
        private void ResetCheckboxes()
        {
            checkBox1Milk.Checked = false;
            checkBox2Socker.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // string message = kaffemaskin.MakeDrink(new Coffee(false, false));
            //this.textBox1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
            
           
        {
            
            // detta sker vid klick på knappen coffee
           // Drink coffee = new Coffee(); // skapa en instans av klassen coffee
           // MessageBox.Show("Du har valt Kaffe \n Vänta kaffe serveras nu ");//(coffee.Make() + "\n" + Drink.CupsServed); // anropa make metoden för objektet coffee och 
            // skriv strängen och antalet serverade koppar i ett popup fönster 
           // this.textBox1.Text = "Varsågod och ta din kaffe";
            //try
            //{
               
            //    string message = kaffemaskin.MakeDrink(new Coffee(false, false));
            //    SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\pouring coffee - sound effect");
            //    pouringSound.Play();
            //    MessageBox.Show("Du har valt Kaffe \n Vänta kaffe serveras nu ");
            //    this.textBox1.Text = message + " är serverat" ;
            //}
            //catch (Exception x)
            //{
            //    textBox1.Text = x.Message;
            //}
            try
            {
                string message = kaffemaskin.MakeDrink(new Coffee((checkBox1Milk.Checked == true), (checkBox2Socker.Checked == true)));
                SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\Barista3000_skal\Sounds\Morning sound of pouring coffee!.wav");
                pouringSound.PlaySync();                // MessageBox.Show("Du har valt Kaffe \n Vänta kaffe serveras nu ");
                this.textBox1.Text = message + " är serverat";
                ResetCheckboxes();
            }
            catch (Exception x)
            {
                textBox1.Text = x.Message;
            }
        }
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Du har valt varm choklad \n VÄNTA Choklad SERVERAS NU");
            //  
            // MessageBox.Show ("Välkommen åter");
            try
            {
                string message = kaffemaskin.MakeDrink(new Chocolate());
                SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\Barista3000_skal\Sounds\Morning sound of pouring coffee!.wav");
                pouringSound.PlaySync();
               // MessageBox.Show("Du har valt varm choklad \n VÄNTA CHOKLAD SERVERAS NU");                
                this.textBox1.Text = "Varm " + message + " är nu serverad";
                ResetCheckboxes();
            }
            catch (Exception x)
            {
                textBox1.Text = x.Message;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
            
           
         private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)

        { 
        }     

        //private void button10_Click_1(object sender, EventArgs e)
        //{
        //   // 
        //  //  this.textBox1.Text = "Varsågod och tar din kaffe";
        //    try
        //    {
        //        string message = kaffemaskin.MakeDrink(new Coffee(true, true));
        //        SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\Barista3000_skal\Sounds\Morning sound of pouring coffee!.wav");
        //        pouringSound.PlaySync();
        //        MessageBox.Show("Du har valt Kaffe med mjölk och socker \n VÄNTA KAFFE SERVERAS NU");
        //        this.textBox1.Text = message + " är serverat";
        //    }
        //    catch (Exception x)
        //    {
        //        textBox1.Text = x.Message;
        //    }
        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{ //Kaffe med socker är beställt
        //   //
        //   // this.textBox1.Text = "Varsågod och tar din kaffe med söcker";
        //    try
        //    {
        //        string message = kaffemaskin.MakeDrink(new Coffee(false, true));
        //        SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\Barista3000_skal\Sounds\Morning sound of pouring coffee!.wav");
        //        pouringSound.PlaySync();
        //        MessageBox.Show("Du har valt Kaffe med socker \n VÄNTA KAFFE SERVERAS NU");
        //        this.textBox1.Text = message + " är serverat";
        //    }
        //    catch (Exception x)
        //    {
        //        textBox1.Text = x.Message;
        //    }
        //}

        private void button3_Click_1(object sender, EventArgs e)
        { }
        //  //  
          
        //    try
        //    {
        //        string message = kaffemaskin.MakeDrink(new Coffee(true, false));
        //        SoundPlayer v = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\Barista3000_skal\Sounds\Morning sound of pouring coffee!.wav");
        //        pouringSound.PlaySync();
        //        MessageBox.Show("Du har valt Kaffe med mjölk \n VÄNTA KAFFE SERVERAS NU ");
        //        this.textBox1.Text = message + " är serverat";
        //    }
        //    catch (Exception x)
        //    {
        //        textBox1.Text = x.Message;
        //    }
        //}

        private void button4_Click_1(object sender, EventArgs e)
        {
           
           // MessageBox.Show("Du har valt Kaffe Late \n VÄNTA KAFFE SERVERAS NU");
            try
            {
              
                string message = kaffemaskin.MakeDrink(new CafeAuLait());
                SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\Barista3000_skal\Sounds\Morning sound of pouring coffee!.wav");
                pouringSound.PlaySync();
               // MessageBox.Show("Du har valt CafeAuLait \n VÄNTA KAFFE SERVERAS NU");
                this.textBox1.Text = message + " är serverat";
                ResetCheckboxes();
            }
            catch (Exception x)
            {
                textBox1.Text = x.Message;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
          //  MessageBox.Show("Du har valt Te Vatten  \n VÄNTA DEN SERVERAS NU");
            try
            {
                string message = kaffemaskin.MakeDrink(new HotWater());
                SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\pouring coffee - sound effect");
                pouringSound.PlaySync();
               // MessageBox.Show("Du har valt Te Vatten  \n VÄNTA DEN SERVERAS NU");
                this.textBox1.Text = message + " är serverat";
            }
            catch (Exception x)
            {
                textBox1.Text = x.Message;
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show("Du har valt Vatten  \n VÄNTA DEN SERVERAS NU");
            try
            {
                string message = kaffemaskin.MakeDrink(new Water());
                SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\Morning sound of pouring coffee!.wav");
                pouringSound.PlaySync();
              //  MessageBox.Show("Du har valt Vatten  \n VÄNTA DEN SERVERAS NU");
                this.textBox1.Text = message + "är serverat";
                ResetCheckboxes();
            }
            catch (Exception x)
            {
                textBox1.Text = x.Message;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        { // Kolsyratvatten är valt
          //  MessageBox.Show("Du har valt kolsyrade vatten  \n VÄNTA DEN SERVERAS NU");
            try
            {
                string message = kaffemaskin.MakeDrink(new SparklingWater());
                SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\Barista3000_skal\Sounds\Sparkling Water Sound.wav");
                pouringSound.PlaySync();
               // MessageBox.Show("Du har valt kolsyrade vatten  \n VÄNTA DEN SERVERAS NU");
                this.textBox1.Text = message + " är serverat";
                ResetCheckboxes();
            }
            catch (Exception x)
            {
                textBox1.Text = x.Message;
            }
        }

        private void button11_Click(object sender, EventArgs e)
         { 
            //Fyller på maskinens alla behållare med 5
            kaffemaskin.refill();
            SoundPlayer pouringSound = new SoundPlayer(@"C:\Users\Acer\Documents\Visual Studio 2012\Projects\Barista3000_Aroka_Lab6\pouring coffee - sound effect");
            pouringSound.PlaySync();
            MessageBox.Show("Vänta maskinen påfyllning!!!");
            this.textBox1.Text = "Maskinen är nu fylld igen";
            ResetCheckboxes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Antal koppar är " + Drink.CupsServed + "\n Kaffenivån är " + CoffeeContainer.level + "\nSockernivån är " + SugarContainer.level + "\nMjöljnivån är " + MilkContainer.level + "\nChoklad nivån är " + ChocolateContainer.level + "\nKolsyre nivån är " + CarbonateContainer.level);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1Milk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1Socker_CheckedChanged(object sender, EventArgs e)
        { 
        
        }
        private void radioButtonSocker_CheckedChanged(object sender, EventArgs e)

        { 
        
        }
        private void radioButtonMilk_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void checkBox1__CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2Socker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }


        
                      
        
    }
}
