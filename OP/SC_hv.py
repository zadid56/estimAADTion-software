from selenium import webdriver
from datetime import timedelta, date
import time
import os
import sys
import pandas

def daterange(start_date, end_date):
    for n in range(int ((end_date - start_date).days)):
        yield start_date + timedelta(n)
URL = 'http://dbw.scdot.org/Poll5WebAppPublic/wfrm/wfrmViewDataNightly.aspx?Site=0001&DisTbl=T'
PathtoChromeDriver = os.path.abspath('C:\\chromedriver.exe')

start_date = date(int(sys.argv[1]), 1, 1)
end_date = date(int(sys.argv[1])+1, 1, 1)
colnames = ['ATR', 'FC'];
data = pandas.read_csv(sys.argv[2], names=colnames)
ATRs = data.ATR.tolist()
ATRs.pop(0)
SiteIDList = list(map(int, ATRs))
BrowserOpen = False
for siteID in SiteIDList:
    OutFile = open(str(siteID)+'.txt', 'w')
    for single_date in daterange(start_date, end_date):
        DateFormatted = single_date.strftime("%m/%d/%Y")
        Downloaded = False
        while not Downloaded:
            if not BrowserOpen:
                browser=webdriver.Chrome(PathtoChromeDriver)
                browser.get(URL)
                BrowserOpen = True
            try:
                SitePicker = browser.find_element_by_name("_ctl0:pageOptions:WucSites1:txtSiteID")
                SitePicker.clear()
                SitePicker.send_keys('{:04.0f}'.format(siteID))
                DatePicker = browser.find_element_by_name("_ctl0:pageOptions:WucDates1:txtDate")
                DatePicker.clear()
                DatePicker.send_keys(DateFormatted)
                GoBtm = browser.find_element_by_name("_ctl0:pageOptions:btnSmGOIcon")
                GoBtm.click()
                DataGrid   = browser.find_element_by_id("_ctl0_mainContent_gridForData")
                Data = str(DataGrid.text)
                OutFile.write(DateFormatted+"\n")
                OutFile.write(Data+"\n")
                Downloaded = True
            except Exception as e:
                print(e)
                browser.quit()
                BrowserOpen = False
                time.sleep(2)
                
    OutFile.close()
browser.quit()
