using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor.Experimental.GraphView;

public class TicTacToeCodes : MonoBehaviour
{
    bool checker;
    int plusone;


    public Text A1 = null;
    public Text A2 = null;
    public Text A3 = null;
    public Text B1 = null;
    public Text B2 = null;
    public Text B3 = null;
    public Text C1 = null;
    public Text C2 = null;
    public Text C3 = null;

    public Text ResetGame = null;
    public Text MsgFeedBack = null;

    public Text txtPlayerX = null;
    public Text txtPlayerO = null;

    public void score()
    {
        if (A1.text == "X" && A2.text == "X" && A3.text == "X")
        {
            A1.color = Color.red;
            A2.color = Color.red;
            A3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);

        }
        if (B1.text == "X" && B2.text == "X" && B3.text == "X")
        {
            B1.color = Color.red;
            B2.color = Color.red;
            B3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);
        }
        if (C1.text == "X" && C2.text == "X" && C3.text == "X")
        {
            C1.color = Color.red;
            C2.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);

        }
        if (A1.text == "X" && B1.text == "X" && C1.text == "X")
        {
            A1.color = Color.red;
            B1.color = Color.red;
            C1.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);
        }
        if (A2.text == "X" && B2.text == "X" && C2.text == "X")
        {
            A2.color = Color.red;
            B2.color = Color.red;
            C2.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);

        }
        if (A3.text == "X" && B3.text == "X" && C3.text == "X")
        {
            A3.color = Color.red;
            B3.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);
        }
        if (A1.text == "X" && B2.text == "X" && C3.text == "X")
        {
            A1.color = Color.red;
            B2.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);

        }
        if (A3.text == "X" && B2.text == "X" && C1.text == "X")
        {
            A3.color = Color.red;
            B2.color = Color.red;
            C1.color = Color.red;
            MsgFeedBack.text = "the winner is player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone);
        }
        // ============================================player O=============================================
        if (A1.text == "O" && A2.text == "O" && A3.text == "O")
        {
            A1.color = Color.red;
            A2.color = Color.red;
            A3.color = Color.red;
            MsgFeedBack.text = "the winner is player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);

        }
        if (B1.text == "O" && B2.text == "O" && B3.text == "O")
        {
            B1.color = Color.red;
            B2.color = Color.red;
            B3.color = Color.red;
            MsgFeedBack.text = "the winner is player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);
        }
        if (C1.text == "O" && C2.text == "O" && C3.text == "O")
        {
            C1.color = Color.red;
            C2.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);

        }
        if (A1.text == "O" && B1.text == "O" && C1.text == "O")
        {
            A1.color = Color.red;
            B1.color = Color.red;
            C1.color = Color.red;
            MsgFeedBack.text = "the winner is player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);
        }
        if (A2.text == "O" && B2.text == "O" && C2.text == "O")
        {
            A2.color = Color.red;
            B2.color = Color.red;
            C2.color = Color.red;
            MsgFeedBack.text = "the winner is player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);

        }
        if (A3.text == "O" && B3.text == "O" && C3.text == "O")
        {
            A3.color = Color.red;
            B3.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);
        }
        if (A1.text == "O" && B2.text == "O" && C3.text == "O")
        {
            A1.color = Color.red;
            B2.color = Color.red;
            C3.color = Color.red;
            MsgFeedBack.text = "the winner is player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);

        }
        if (A3.text == "O" && B2.text == "O" && C1.text == "O")
        {
            A3.color = Color.red;
            B2.color = Color.red;
            C1.color = Color.red;
            MsgFeedBack.text = "the winner is player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone);
        }



    }
    public void A1_Click()
    {
        if (checker == false)
        {
            A1.text = "X";
            checker = true;
        }
        else 
        {
            A1.text = "O";
            checker = false;
        }
        score();
    }
    public void A2_Click()
    {
        if (checker == false)
        {
            A2.text = "X";
            checker = true;
        }
        else
        {
            A2.text = "O";
            checker = false;
        }
        score();
    }
    public void A3_Click()
    {
        if (checker == false)
        {
            A3.text = "X";
            checker = true;
        }
        else
        {
            A3.text = "O";
            checker = false;
        }
        score();
    }
    public void B1_Click()
    {
        if (checker == false)
        {
            B1.text = "X";
            checker = true;
        }
        else
        {
            B1.text = "O";
            checker = false;
        }
        score();
    }
    public void B2_Click()
    {
        if (checker == false)
        {
            B2.text = "X";
            checker = true;
        }
        else
        {
            B2.text = "O";
            checker = false;
        }
        score();
    }
    public void B3_Click()
    {
        if (checker == false)
        {
            B3.text = "X";
            checker = true;
        }
        else
        {
            B3.text = "O";
            checker = false;
        }
        score();
    }
    public void C1_Click()
    {
        if (checker == false)
        {
            C1.text = "X";
            checker = true;
        }
        else
        {
            C1.text = "O";
            checker = false;
        }
        score();
    }
    public void C2_Click()
    {
        if (checker == false)
        {
            C2.text = "X";
            checker = true;
        }
        else
        {
            C2.text = "O";
            checker = false;
        }
        score();
    }
    public void C3_Click()
    {
        if (checker == false)
        {
            C3.text = "X";
            checker = true;
        }
        else
        {
            C3.text = "O";
            checker = false;
        }
        score();
    }

    public void btnResetGame_Click()
    {
        A1.text = "";
        A2.text = "";
        A3.text = "";
        B1.text = "";
        B2.text = "";
        B3.text = "";
        C1.text = "";
        C2.text = ""; 
        C3.text = "";

        A1.color = Color.black;
        A2.color = Color.black;
        A3.color = Color.black;
        B1.color = Color.black;
        B2.color = Color.black;
        B3.color = Color.black;
        C1.color = Color.black;
        C2.color = Color.black;
        C3.color = Color.black;

    }
}
