import requests
import bs4

def getERate(conv1="USD", conv2="KRW"):
    """
    :param conv1=USD:
    :param conv2=KRW:
    :return res_code == 200 ? e_rate : None
    """
    URL = "https://finance.naver.com/marketindex/exchangeDetail.naver?marketindexCd=FX_"
    URL += conv1 + conv2
    res = requests.get(URL)
    if res.status_code // 100 == 2:
        soup = bs4.BeautifulSoup(res.text, 'html.parser')
        td = soup.select('#content > div.section_calculator > table:nth-child(4) > tbody > tr > td:nth-child(1)')
        convert = float(td[0].text.replace(",", ""))
        return convert
    else:
        return None
