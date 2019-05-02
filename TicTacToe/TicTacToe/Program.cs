using System;
using Selenium.Functions;
using TicTacToe.PageObjects;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            SeleniumDriver.Open(@"https://codepen.io/jshlfts32/full/bjambP/");

            Page page = new Page();

            SeleniumDriver.Driver.SwitchTo().Frame("result");

            //Validate play key funtional
            page.textbox().Click();
            page.textbox().SetValue("3");
            page.playbutton().Click();
            page.a1().Click();
            page.b1().Click();
            page.a2().Click();
            page.b2().Click();
            page.a3().Click();
            page.endgame().IsElementVisible();
            SeleniumDriver.Close();

            SeleniumDriver.Open(@"https://codepen.io/jshlfts32/full/bjambP/");

            //Validate Love (Heart) icon Visble
            page.lovebutton().IsElementVisible();
             SeleniumDriver.Close();

             SeleniumDriver.Open(@"https://codepen.io/jshlfts32/full/bjambP/");

            //Validate Fork screen display
            page.forkbutton().Click();
            page.htmlsign().IsElementVisible();
            SeleniumDriver.Close();

           
            SeleniumDriver.Open(@"https://codepen.io/jshlfts32/full/bjambP/");

            //Validate Edit/View mode
            page.changebutton().Click();
            page.editview().Click();
            
            // Will add the rest of the clicks and setting values
            SeleniumDriver.Close();
        }
    }
}
