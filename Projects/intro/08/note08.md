## 2022-05-29(화), chapter 08 note

### While
- while은 '~하는 동안' 이란 뜻을 가진다. (접속사)
```
// 기본형
while (조건식)
{
    조건을 만족할 때만 실행
}
```
- 조건이 거짓이 되지 않는 한 중괄호 사이의 코드를  반복해서 실행한다. 
- if문은 중괄호 안의 코드를 한 번만 실행하고, while문은 조건식이 참이라면 반복해서 실행한다. 

#### break
- break를 쓰면 즉시 while문을 끝낼 수 있다. 
- 조건식에 true를 넣게 되면 계속 반복한다. 이럴 경우 정상적으로 처리가 되어도 반복하게 되므로 'break'키워드를 사용할 필요가 있다.

#### continue
- break가 while문에서 나가는 역할이라면 continue는 즉시 while문의 첫 줄부터 다시 실행하게 된다. 
```
// continue 예시

int count = 0;
while (true)
{
    count = count + 1;
    if (count == 3)
    {
        continue;
    }
    Console.Write(count);
    Console.WriteLine("번째 출력");
}

// 실행하게되면 "0번째 출력"부터 "2번째 출력"까지 출력하고,
// "3번째 출력"은 출력되지 않는다. count가 3이면
// continue를 호출해서 아래의 코드는 무시하고 while(true)로 이동한다. 

```