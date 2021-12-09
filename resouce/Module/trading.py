import ccxt


# 사용 설명서
# https://github.com/ccxt/ccxt
# https://khream.tistory.com/8
# https://wikidocs.net/31065
# https://wikidocs.net/129900

# binance status
# res['info']['status']
# 'FILLED' => 포지션 상태.
# 'NEW' => 오픈 오더 상태. 즉, 포지션 들어가기 전.

def getOpenOrders(instace, market):
    try:
        res = None
        if isinstance(instace, ccxt.upbit):
            res = instace.fetch_open_orders(market + "/KRW")
        else:
            res = instace.fetch_open_orders(market + "/USDT")
    except Exception as e:
        print(e)
        print("getOpenOrders")
        return None

    return res


def getClosePrice(instance, market):
    try:
        res = None
        if isinstance(instance, ccxt.upbit):
            res = instance.fetch_ticker(market + "/KRW")
        else:
            res = instance.fetch_ticker(market + "/USDT")
    except Exception as e:
        print(e)
        print("getClosePrice")
        return None

    return res['close']


def cancelOrder(instance, order, market):
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


def getOrderCheck(instance, order, market):
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


def Sell(instance, market, amounts, price, params: dict = {}):
    try:
        res = None
        if isinstance(instance, ccxt.upbit):
            if price != -1:
                res = instance.create_limit_sell_order(market + "/KRW", amounts, price,
                                                       {'execInst': 'ParticipateDoNotInitiate'})
            else:
                res = instance.create_market_sell_order(market + "/KRW", amounts)
        else:
            if price != -1:
                res = instance.create_limit_sell_order(market + "/USDT", amounts, price, params)
            else:
                res = instance.create_market_sell_order(market + "/USDT", amounts)

    except Exception as e:
        print(e)
        print("Sell")
        return None

    res['market'] = market
    return res


def Buy(instance, market, amounts, price, params: dict = {}):
    try:
        res = None
        if isinstance(instance, ccxt.upbit):
            if price != -1:
                res = instance.create_limit_buy_order(market + "/KRW", amounts, price,
                                                      {'execInst': 'ParticipateDoNotInitiate'})
            else:
                res = instance.create_market_buy_order(market + "/KRW", amounts)
        else:
            if price != -1:
                res = instance.create_limit_buy_order(market + "/USDT", amounts, price, params)
            else:
                res = instance.create_market_buy_order(market + "/USDT", amounts)
    except Exception as e:
        print(e)
        print("Buy")
        return None

    return res


def getOrderBookSide(instance, market, limit, status):
    try:
        res = getOrderBook(instance, market, limit)

        if status in [False, 'sell', 'Sell', 's', 'S', 'asks']:
            return res['asks'][limit - 1]
        elif status in [True, 'buy', 'Buy', 'b', 'B', 'bids']:
            return res['bids'][limit - 1]
        else:
            print("status is not valid value.")
            return None
    except Exception as e:
        print(e)
        print("getOrderBookside")
        return None


def getOrderBook(instance, market, limit):
    try:
        res = None
        """
        06-12-2021 Comment.
        binance에서 limit 정해져 있는 듯 함.
        따라서 10, 20, 50, 100가 있으므로, 각 구간의 최댓값으로 바꾸면 됨.
        """
        limit = 10 if limit <= 10 else 20 if limit <= 20 else 50 if limit <= 50 else 100 if limit <= 100 else limit
        if isinstance(instance, ccxt.upbit):
            res = instance.fetch_order_book(market + "/KRW", limit=limit)
        else:
            res = instance.fetch_order_book(market + "/USDT", limit=limit)
    except Exception as e:
        print(e)
        print("getOrderBook")
        return None

    return res


def getInstanceUpbit(apiKey, secKey):
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


def getInstanceBinance(apiKey, secKey):
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
