using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnaMaster : System.Web.UI.MasterPage
{
    public static int sayac=0;
   
    public void slider(){
        
        if (sayac==1)
	{
            Label1.Text = "<img src='resimler/1.jpg' width='960' height='400'/>";
	}
       else if (sayac == 2)
        {
            Label1.Text = "<img src='resimler/2.jpg' width='960' height='400'/>";
        }
       else if (sayac == 3)
        {
           Label1.Text = "<img src='resimler/3.jpg' width='960' height='400'/>";
        }
      else if (sayac == 4)
        {
            Label1.Text = "<img src='resimler/1.jpg' width='960' height='400'/>";
        }
     else if (sayac == 5)
        {
            Label1.Text = "<img src='resimler/5.png' width='960' height='400'/>";
        }
     else if (sayac == 6)
        {
            Label1.Text = "<img src='resimler/6.png' width='960' height='400'/>";
        }
    }
    public void Page_Load(object sender, EventArgs e)
    {

        sayac = sayac + 1;
        if (sayac == 6)
        {
            sayac = 1;
        }
        slider();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // geri
        slider();
        sayac = sayac - 1;
        if (sayac==0)
        {
            sayac = 6;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //ileri
        slider();
        sayac = sayac + 1;
        if (sayac == 6)
        {
            sayac = 1;
        }
    }
}
