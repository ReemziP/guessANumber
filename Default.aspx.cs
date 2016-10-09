using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Text;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    private static byte clickCount = 0;
    private static byte randomNumber = 0;
    private string filePath = @"D:\scores.txt";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clickCount++;       

        Debug.WriteLine("clickCount: " + clickCount);

        if (clickCount == 1)
        {
            Random random = new Random();
            randomNumber = Convert.ToByte(random.Next(1, 100));
            Debug.WriteLine("randomNumber: " + randomNumber);
        }

        if (clickCount == 100)
        {
            btnGuessNumber.Enabled = false;
        }

        byte userInput = Convert.ToByte(txtGuessedNumber.Text);
        byte clickRemaining = Convert.ToByte(100 - clickCount);

        txtGuessesMade.Text = Convert.ToString(clickCount);
        txtGuessesRemaining.Text = Convert.ToString(clickRemaining);

        if (randomNumber > userInput)
        {
            lblOutput.Text = "Too low, try again.";
        }
        else if (randomNumber < userInput)
        {
            lblOutput.Text = "Too high, try again.";
        }
        else
        {
            lblOutput.Text = "Congratulations. You win!";
            txtGeneratedNo.Text = Convert.ToString(randomNumber);
            txtScore.Text = Convert.ToString(clickRemaining);

            storeHighScore(txtNickName.Text, clickRemaining);
        }      
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clickCount = 0;
        randomNumber = 0;

        txtNickName.Text = "";
        txtScore.Text = "";
        txtGuessesRemaining.Text = "";
        txtGuessesMade.Text = "";
        txtGuessedNumber.Text = "";
        txtGeneratedNo.Text = "";

        lblOutput.Text = "";

        tblViewScore.Visible = false;

        btnGuessNumber.Enabled = true;
    }

    protected void btnViewScores_Click(object sender, EventArgs e)
    {
        viewScores();
    }

    private void storeHighScore(string nickName, byte score)
    {
        string [] setLines = new string[1];

        setLines[0] = nickName+"|"+score;

        File.AppendAllLines(filePath, setLines, Encoding.UTF8);        
    }

    private void viewScores()
    {
        tblViewScore.Visible = true;

        string[] getLines = File.ReadAllLines(filePath);
        string [] split;

        foreach (string line in getLines)
        {
            split = line.Split('|');

            TableRow row = new TableRow();
            TableCell cell1 = new TableCell();
            cell1.Text = split[0]; //Nick name

            TableCell cell2 = new TableCell();
            cell2.Text = split[1]; //scores

            row.Cells.Add(cell1);
            row.Cells.Add(cell2);

            tblViewScore.Rows.Add(row);
        }
    }
}