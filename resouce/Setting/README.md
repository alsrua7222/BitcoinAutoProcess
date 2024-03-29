# Setting 양식(Version 1.1.0)

```text
"텔레그램 토큰 값"
"업비트 공개 키"
"업비트 비밀 키"
"바이낸스 공개 키"
"바이낸스 비밀 키"
"갱신 시간"->float "로그 기록 여부"->bool "테스트"->bool
"코인 이름(대문자 영어 필수)"->str "최저 김프"->float "최고 김프"->float "알람 여부"->bool "자동매매 여부"->bool "공매도 바이낸스 호가창 N틱 이상"->int "공매도 바이낸스 코인 수량"->float "매수 업비트 코인 수량"->float "공매도 바이낸스 호가창 제한 수"->int "공매수(리듀스온리) 바이낸스 호가창 N틱 이하"->int "공매수(리듀스온리) 바이낸스 코인 수량"->float "매도 업비트 코인 수량"->float "공매수(리듀스온리) 바이낸스 호가창 제한 수"->int
"코인 이름"->str "최저 김프"->float -> ......
......
```

---

# Tips
코인 종목 수가 많을 수록 통신 시간이 더 늦어집니다.    
갱신 시간의 최소 시간은 각 네트워크 환경에서 통신할 때 완료되는 시간입니다.
API 값들 다 비우고 하면, 가격 김프 조회만 할 수 있습니다.

---

## Example 1
`갱신시간 0.001초, 로그 기록 안함, 테스트 모드 안함`    
`도지코인(DOGE), 최저 김프는 2.1%, 최고 김프는 2.6%, 알람 안함, 자동매매 함`   
`최저 김프 감지되면 호가창 5틱 이상의 가격에 50주 공매도 주문한다. 체결되면 한국 매수 50주 시장가로 주문한다. 체결이 안된 상태에서 호가창 40틱 이상의 가격을 넘는다면 취소한다.`    
`최고 김프 감지되면 호가창 5틱 아래의 가격에 50주 공매수(리듀스온리) 주문한다. 체결되면 한국 매도 50주 시장가로 주문한다. 체결이 안된 상태에서 호가창 40틱 이상의 가격을 넘는다면 취소한다.`   
```text
SAD5F64SD8F1AS6AR7D2R1ZX8DJDDAS
VXC8V78A9T8WEQR7A8R79SDAFSD8VAS
DF8AS7ASU87UZJ78FCKDS5F4DS1DFSG
A9RQWE87Y8RE7TS866SDSD4FF5ASDF4
Y7Z8FDS7A8F7A9ET7ZF45G6H4DFH123
0.001 False False
DOGE 2.1 2.6 False True 5 50 50 40 5 50 50 40
```

## Example 2
`갱신시간 60초, 로그 기록 함, 테스트 모드 함`   
`도지코인(DOGE), 최저 김프는 3.9%, 최고 김프는 5.1%, 알람 함, 자동매매 함`    
`최저 김프 감지되면 호가창 4틱 이상의 가격에 200주 공매도 주문한다. 체결되면 한국 매수 100주 시장가로 주문한다. 체결이 안된 상태에서 호가창 30틱 이상의 가격을 넘는다면 취소한다.`    
`최고 김프 감지되면 호가창 6틱 아래의 가격에 180주 공매수(리듀스온리) 주문한다. 체결되면 한국 매도 100주 시장가로 주문한다. 체결이 안된 상태에서 호가창 40틱 이상의 가격을 넘는다면 취소한다.`   
`비트코인(BTC), 최저 김프는 2.1%, 최고 김프는 2.6%, 알람 안함, 자동매매 함`    
`최저 김프 감지되면 호가창 5틱 이상의 가격에 50주 공매도 주문한다. 체결되면 한국 매수 50주 시장가로 주문한다. 체결이 안된 상태에서 호가창 40틱 이상의 가격을 넘는다면 취소한다.`    
`최고 김프 감지되면 호가창 5틱 아래의 가격에 50주 공매수(리듀스온리) 주문한다. 체결되면 한국 매도 50주 시장가로 주문한다. 체결이 안된 상태에서 호가창 40틱 이상의 가격을 넘는다면 취소한다.`   
```text
SAD5F64SD8F1AS6AR7D2R1ZX8DJDDAS
VXC8V78A9T8WEQR7A8R79SDAFSD8VAS
DF8AS7ASU87UZJ78FCKDS5F4DS1DFSG
A9RQWE87Y8RE7TS866SDSD4FF5ASDF4
Y7Z8FDS7A8F7A9ET7ZF45G6H4DFH123
60 True True
DOGE 3.9 5.1 True True 4 200 100 30 6 180 100 40
BTC 2.1 2.6 False True 5 50 50 40 5 50 50 40
```
