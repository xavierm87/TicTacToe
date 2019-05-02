using OpenQA.Selenium;

namespace TicTacToe.ObjectRepository
{
    public static class Repository
    {
        public static readonly By textbox = By.XPath("//*[@id='number']");

        public static readonly By a1 = By.XPath("//*[@id='0']");

        public static readonly By b1 = By.XPath("//*[@id='1']");


        public static readonly By a2 = By.XPath("//*[@id='3']");

        public static readonly By b2 = By.XPath("//*[@id='4']");

        public static readonly By a3 = By.XPath("//*[@id='6']");

        public static readonly By playbutton = By.XPath("//*[@id='start']");

        public static readonly By forkbutton = By.XPath("//*[@id='fork']");

        public static readonly By lovebutton = By.XPath("//*[@id='main-header']/div[2]/div[2]/button[1]");

        public static readonly By changebutton = By.XPath("//*[@id='view-switcher-button']/span");

        public static readonly By editview = By.XPath("//*[@id='pen-link']");

        public static readonly By htmlsign = By.XPath("//*[@id='html-editor-title']");

        public static readonly By endgame = By.XPath("//*[@id='endgame']");

    }
}
