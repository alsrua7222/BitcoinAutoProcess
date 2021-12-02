import ccxt


# 사용 설명서
# https://github.com/ccxt/ccxt
# https://khream.tistory.com/8
# https://wikidocs.net/31065
# https://wikidocs.net/129900

class TradeModule:
    def cancelOrder(self, instance, order, market):
        try:
            res = None
            if isinstance(instance, ccxt.upbit):
                res = instance.cancel_order(order['info']['uuid'], market + "/KRW")
            else:
                res = instance.cancel_order(order['info']['orderId'], market + "/USDT")
        except Exception as e:
            print(e)
            print("cancelOrder")
            return None

        return res

    def getOrderCheck(self, instance, order, market):
        try:
            res = None
            if isinstance(instance, ccxt.upbit):
                res = instance.fetch_order(order['info']['uuid'], market + "/KRW")
            else:
                res = instance.fetch_order(order['info']['orderId'], market + "/USDT")
        except Exception as e:
            print(e)
            print("order_check")
            return None
        return res

    def Sell(self, instance, market, amounts, price):
        try:
            res = None
            if isinstance(instance, ccxt.upbit):
                if price != -1:
                    res = instance.create_limit_sell_order(market + "/KRW", amounts, price, {'execInst': 'ParticipateDoNotInitiate'})
                else:
                    res = instance.create_market_sell_order(market + "/KRW", amounts)
            else:
                if price != -1:
                    res = instance.create_limit_sell_order(market + "/USDT", amounts, price, {'execInst': 'ParticipateDoNotInitiate'})
                else:
                    res = instance.create_market_sell_order(market + "/USDT", amounts)

        except Exception as e:
            print(e)
            print("Sell")
            return None

        res['market'] = market
        return res

    def Buy(self, instance, market, amounts, price):
        try:
            res = None
            if isinstance(instance, ccxt.upbit):
                if price != -1:
                    res = instance.create_limit_buy_order(market + "/KRW", amounts, price, {'execInst': 'ParticipateDoNotInitiate'})
                else:
                    res = instance.create_market_buy_order(market + "/KRW", amounts)
            else:
                if price != -1:
                    res = instance.create_limit_buy_order(market + "/USDT", amounts, price, {'execInst': 'ParticipateDoNotInitiate'})
                else:
                    res = instance.create_market_buy_order(market + "/USDT", amounts)
        except Exception as e:
            print(e)
            print("Buy")
            return None

        return res

    def getOrderBook(self, instance, market):
        try:
            res = None
            if isinstance(instance, ccxt.upbit):
                res = instance.fetch_order_book(market + "/KRW", limit=40)
            else:
                res = instance.fetch_order_book(market + "/USDT", limit=40)
        except Exception as e:
            print(e)
            print("getOrderBook")
            return None

        return res

    def getClassUpbit(self, apiKey, secKey):
        try:
            res = None
            res = ccxt.upbit(config={
                "apiKey": apiKey,
                "secret": secKey
            })
        except Exception as e:
            print(e)
            return None

        return res

    def appendKeyForBinance(self, apiKey="", secKey=""):
        try:
            res = None
            res = ccxt.binance(config={
                'apiKey': apiKey,
                'secret': secKey,
                'enableRateLimit': True,
                'options': {
                    'defaultType': "future"
                }
            })
        except Exception as e:
            print(e)
            return None

        return res
