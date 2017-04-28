//--------------------------------------------------------------
//
// Browser Efficiency Test
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// MIT License
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files(the ""Software""),
// to deal in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE AUTHORS
// OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF
// OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//--------------------------------------------------------------

using System;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;
using System.Threading;
using OpenQA.Selenium;

namespace BrowserEfficiencyTest
{
    internal class AlexaTop100 : Scenario
    {
        public AlexaTop100()
        {
            Name = "AlexaTop100";
            DefaultDuration = 60 * 10; // 10 minutes
        }

        public override void Run(RemoteWebDriver driver, string browser, CredentialManager credentialManager, ResponsivenessTimer timer)
        {

            string[] sites = new string[] {
              "accounts.google.com",
              "alibaba.com",
              "aliexpress.com",
              "amazon.com",
              "aol.com",
              "apple.com",
              "apps.facebook.com",
              "ask.com",
              "bankofamerica.com",
              "bing.com",
              "blogger.com",
              "blogspot.com",
              "booking.com",
              "calendar.google.com",
              "chaseonline.chase.com",
              "craigslist.org",
              "detail.tmall.com",
              "direct.asda.com",
              "docs.google.com",
              "drive.google.com",
              "dropbox.com",
              "ebay.com",
              "en.wikipedia.org",
              "espn.go.com",
              "etsy.com",
              "facebook.com",
              "finance.yahoo.com",
              "github.com",
              "gmail.com",
              "go.microsoft.com",
              "google.com",
              "healthline.com",
              "home.tb.ask.com",
              "homepage-web.com",
              "hotmail.com",
              "hsrd.yahoo.com",
              "ikea.com",
              "images.search.yahoo.com",
              "imdb.com",
              "imgur.com",
              "indeed.com",
              "instagram.com",
              "int.search.tb.ask.com",
              //"kohls.com",
              //"lenovo.com",
              "linkedin.com",
              "login.live.com",
              "login.microsoftonline.com",
              "login.yahoo.com",
              "maceys.com",
              "mail.aol.com",
              "mail.google.com",
              "mail.live.com",
              "mail.twc.com",
              "mail.yahoo.com",
              "microsoft.com",
              "monitor.macromill.com",
              "msn.com",
              "my.screenname.aol.com",
              "mysearch.avg.com",
              "netflix.com",
              "office.com",
              "onedrive.live.com",
              "online.wellsfargo.com",
              "outlook.com",
              "outlook.live.com",
              "outlook.office365.com",
              "picasaweb.google.com",
              "pinterest.com",
              "plus.google.com",
              "pof.com",
              "pogo.com",
              "portal.office.com",
              "prodigy.msn.com",
              "reddit.com",
              "roblox.com",
              "search.ask.com",
              "search.yahoo.com",
              "serve.popads.net",
              "stackoverflow.com",
              "start.new.toshiba.com",
              "startpage.lenovo.com",
              "translate.google.com",
              "trc.taboola.com",
              "trulia.com",
              "tumblr.com",
              "twitter.com",
              "us.norton.com",
              "walmart.com",
              "web.facebook.com",
              "web.mail.comcast.net",
              "web.roblox.com",
              "windows.microsoft.com",
              "wordpress.com",
              "www.live.com",
              "www.paypal.com",
              "xfinity.com",
              "yahoo.com",
              "youtube.com",
              "zillow.com"
            };

            for (int i = 0; i < sites.Length; i++)
            {
                var site = sites[i];
                driver.Navigate().GoToUrl("http://" + site);
                driver.WaitForPageLoad();
                driver.Wait(10);
            }

            timer.ExtractPageLoadTime("AlexaTop100");

        }
    }
}
