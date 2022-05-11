<h2> 2022-05-12(목), chapter 05 note </h2>

---

<h3>입력</h3>

- 입력 : 빌드가 끝난 프로그램에 사용자가 값을 넣어주는 것

- 키보드 입력을 받을 때는 Console.ReadLine() 함수를 사용한다.
Console.WriteLine() 함수와 비슷한 형태이다. Write가 Read로 바뀌었을 뿐이다.

```
string userInput = Console.ReadLine();

Console.Write(userInput);
```
1. Console.ReadLine() 함수로 사용자의 키보드 ㅇ비력을 받는다.
2.  1에서 받은 입력값을 userInput 변수에 넣어준다.
3.  
- Console.ReadLine() 함수는 사용자의 입력값을 문자열형으로 만들어준다.


<h3>문자열 변환</h3>

- 문자열을 정수로 변환할 때 사용하는 함수는 int.Parse() 함수이다.

- int.Parse() : int(integer, 정수, 명사) + Parse(해석하다, 동사)
ex) "1234" 문자열을 1234 정수형으로 바꿔줌.

- 입력 문자열의 형식을 틀리지 않도록 주의하기.
ex) int.Parse()를 사용했을 때는 꼭 숫자를 입력해야한다는 사실을 기억하자.

