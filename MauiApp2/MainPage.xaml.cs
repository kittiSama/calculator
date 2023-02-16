namespace MauiApp2;

public partial class MainPage : ContentPage
{
	int num1 = 0;
	int num2 = 0;
	string operation = "";
	int useless;
	bool flag = false;
	public MainPage()
	{
		InitializeComponent();

	}
	public void inp(object sender, EventArgs args)
    {
		if (flag) { theoutput.Text = ""; flag = false; } 
		string temp = ((Button)sender).Text;
		theoutput.Text = theoutput.Text+temp;
        if (int.TryParse(temp, out useless))
		{
            if (operation == "")
            {
                num1 = useless;
            }
            else
            {
                num2 = useless;
            }
        }
		if (temp == "+" || temp == "-") operation = temp;
		if (temp == "=")
		{
			if (operation == "+")
			{

				theoutput.Text = (num1 + num2).ToString();

            }
            if (operation == "-")
            {

                theoutput.Text = (num1 - num2).ToString();

            }
			num1 = 0;
			num2 = 0;
			operation = "";
			flag = true;
        }


	}
}

