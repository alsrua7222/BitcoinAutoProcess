# Version 1.0.2 (CMD)

```
1단계: 준비물 확인(Log 관련 파일, exe 실행 파일, 셋팅 설정 파일)
2단계: Setting.txt 구조 및 사용 방법
3단계: 실행하기(과정 설명)
```

## 1단계 준비물 확인
- 0
![img](../image/cmd/0.PNG/)
- 1
![img](../image/cmd/1.PNG/)
## 2단계 Setting.txt 구조 및 사용 방법
- 2
![img](../image/cmd/2.PNG/)
- 3
![img](../image/cmd/3.PNG/)   
여기에서 다음 양식과 같습니다.   
```주의 사항   
분봉 단위: 1(분), 3, 5, 10, 15, 30, 60, 240 중 하나만 골라서 입력. (숫자만 입력)   
갱신 시간: 0.124 입력하면 0.124초마다 갱신됨. 단, 각 환경에 따라 통신 속도가 틀리므로 갱신 속도가 통신 속도보다 빠르면 최소 속도는 통신 속도가 됨을 알려드립니다.   
OnOff: True or False 중 하나만 입력.   
```   
(텔레그램 Token API)   
(분봉 단위) (갱신 시간) (로그OnOff) (고정 환율 한국 1원당 13.00루피)   
(코인 단위) (최솟값) (최댓값) (알람OnOff)      
(코인 단위) (최솟값) (최댓값) (알람OnOff)   
(코인 단위) (최솟값) (최댓값) (알람OnOff)   
...
Ex1)   
asdfjkasdfjaskldfjaskfjasfasklfjasklfj   
1 0.1 True 13.00   
BTC 0.5 1.3 True   
DOGE 1.4 2.3 False   
   
Ex2) 전체 알람 기능을 끄려면 Token API 값을 안 채우고 Enter 키를 눌러주세요.   
   
3 1 False 13.00   
BTC 0.5 1.4 True   
DOGE 1.4 2.3 False   
   
## 3단계 실행하기
- 4
![img](../image/cmd/4.PNG/)
편하게 실행하세요.
- 5
![img](../image/cmd/5.PNG/)
초기 셋팅입니다.
- 6
![img](../image/cmd/6.PNG/)
```
주의: 환율 차이의 공식은 다음과 같습니다. ((한국upbit 금액) - (인도네시아에서 한국으로 환산한 금액)) / (한국upbit 금액) * 100.0   
```   
형식은 (코인 단위), (인도네시아upbit 금액), (인도네시아-한국으로 환산 금액), (한국upbit 금액), (환율 차이)와 같습니다.    
이 때, BTC의 최댓값 조건인 1.7%보다 크므로 환율 차이를 강조되게끔 표현했습니다.   
- 7
![img](../image/cmd/7.PNG/)
Ctrl + C 동시에 누르면 종료됩니다.   
