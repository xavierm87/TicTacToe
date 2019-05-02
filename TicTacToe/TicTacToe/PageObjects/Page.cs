using TicTacToe.ObjectRepository;
using TicTacToe.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.PageObjects
{
    class Page
    {

        public PageElement textbox()
        {
            return new PageElement().WithLocator(Repository.textbox);
        }
        public PageElement playbutton()
        {
            return new PageElement().WithLocator(Repository.playbutton);

        }
        public PageElement forkbutton()
        {
            return new PageElement().WithLocator(Repository.forkbutton);
        }
        public PageElement lovebutton()
        {
            return new PageElement().WithLocator(Repository.lovebutton);
        }
        public PageElement changebutton()
        {
            return new PageElement().WithLocator(Repository.changebutton);
        }

        public PageElement editview()
        {
            return new PageElement().WithLocator(Repository.editview);
        }
        public PageElement htmlsign()
        {
            return new PageElement().WithLocator(Repository.htmlsign);
        }
            public PageElement a1()
            {
                return new PageElement().WithLocator(Repository.a1);
            }
        public PageElement b1()
        {
            return new PageElement().WithLocator(Repository.b1);
        }
            public PageElement a2()
                {
                    return new PageElement().WithLocator(Repository.a2);
                }
        public PageElement b2()
        {
            return new PageElement().WithLocator(Repository.b2);
        }
        public PageElement a3()
        {
            return new PageElement().WithLocator(Repository.a3);
        }
            public PageElement endgame()
                    {
                return new PageElement().WithLocator(Repository.endgame);
            }
    }
}
