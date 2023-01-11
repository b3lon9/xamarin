delegate : 설계방법
- [반환타입] 메서드명(인자1, 인자2...)  
  
대신 사용한다는 것이 더 이상한 말이다.  
설계의 관점으로 보면 이해가 쉬움  
  
```C#
delegate int calc_dele(int a, int b);
```

위와 같이 설계를 해준다.  
이후로 `delegate`함수는 여러 함수를 담아서 줄을 세워 사용한다

```c#
calc_dele c1 = new calc_dele(add);
c1 += new calc_dele(minus); 
```

순서대로 계산되며 진행됨