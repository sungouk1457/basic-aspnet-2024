# basic-aspnet-2024
IoT 개발자과정 ASP.NET 리포지토리

## 1일차
- 웹기술 개요
    - World Wide Web 은 인터넷의 한 파트
    - FULL-Stack
        - Front-end : 웹사이트 화면으로 사람들에게 보이는 부분 기술
        - Back-end : 웹사이트 뒤에서 동작하는 서버기술
        - Server-Operation : HW, OS, SW등 운영(클라우드)

- 업무용 웹 사이트 참조
    - https://www.ecount.com/kr/ECK/ECK004M_CN.aspx

- Front-end(클라이언트)
    - HTML5
    - CSS
    - Javascript()

- Back-end(서버)
    1. Java - Spring, Spring Boot, JSP, EJB...
    2. Javascript - Node js, Express...
    3. Python - Django, Flask, fastAPI, ...
    4. C# - ASP.NET
    5. Ruby - Ruby on rails
    6. C - cgi, fasCGI
    7. PHP

- 개발
    - 프론트앤드 전부 + 백엔드 여러개 중 하나 + DB
    - 웹 브라우저에서 F12(개발자 도구)
    - VS Code 플러그인
        - HTML Code Snippet
        - Live Server

- HTML5
    - XML(eXtensible Markup Language)이 웹페이지 구성하기 위한 선행기술, 너무 복잡해서 간략화 시킨 것
    - Hyper Text Markup Language
    - 기본적으로 확장자 .html
    - Tip! lorem 탭, 긴 샘플텍스트 생성
    - 요소(body)
        - h1 ~ h6 : 제목(마크다운 #, ##와 동일)
        - p : 일반문장
        - div : 그룹화 구분자, 아주 중요(CSS 연계 디자인)
        - img : 이미지 표현
        - br : 한줄 내리기(엔터)
        - 특수문자 : &; 사이에 영문자로 표시(너무 많음)
        - strong 또는 b : 볼드체
        - em : 이탤릭체
        - mark : 형광펜 효과
        - small, sub, sup : 글자 작게, 아래첨자, 윗첨자
        - u, strike : 밑줄, 취소선
        - a : 웹페이지 링크(중요!)
        - ul, ol > li : 순서없는 목록, 순번있는 목록
        - table, tr, th, td : 테이블 만드는 태그
        - audio, video : 오디오, 비디오
        - object, embed : 객체 추가

- HTML + CSS + Javascript
    - 내부 스타일, 외부 스타일, 인라인 스타일
    - 내부 스크립트, 외부 스크립트, 인라인 스크립트
- 오류, 디버그
    - F12 개발자도구로 활용

- 양식태그(body > form안에 사용 필수)
    - front-end 입력한 내용이 back-end로 보내기위한 관문
    - form 을 반드시 사용
    - input
        - type="text" : 텍스트박스
        - type="password" : 비밀번호박스
        - type='button' : 일반버튼
        - type="submit" : 제출(!)
        - checkbox : 체크박스
        - radio : 라디오버튼
        - file : 파일 업로드
        - image : 이미지(img 와 유사)
        - reset : 폼내의 입력양식태그 값 초기화
        - hidden : 숨김값(유용하게 사용!!!)
    - textarea : 여러행 텍스트 입력
    - select, option : 콤보박스
    - fieldset : 그룹박스
    - submit 클릭 loopback(값 전달)발생
    - 값 전달 방법
        - GET : URL뒤 ?다음에 key=value&key=value ... 데이터 전달
        - POST : 화면뒤로 숨겨서 데이터 전달 방식

- 공간구분 태그
    - span - 한줄로 공간구성
    - div - 행간으로 블록지정 공간구성
## 2일차
- HTML5
    - 시맨틱 웹 - 시맨틱 태그로 화면을 구조를 잡는 웹구성 방식
        - header, main, content, nav, footer, aside, section, article... 태그 사용(화면에 안나타남)
        - 시맨틱 태그를 div로 바꿔도 똑같이 동작하기 때문에 요새는 많이 사용안함. 걷어내고 있는 추세
- CSS3
    - 웹 디자인 핵심, Cascding Styles Sheets
    - 상단에서부터 <body>부터 하위에 태그들에 계속해서 적용되는 스타일이라는 뜻
    - 선택지에서 주어지는 디자인 속성
    - 선택지(selector)
    - 속성(property)
    - 배경,폰트
    - 레이아웃
        - HTML 만으로는 화면 레이아웃이 만들어지지 않음
        - 중앙정렬, 원트루, 고정바...
    - 반응형 앱(responsive Web)
    - 메타태그 viewport를 사용하면 그때부터 반응형 웹이 됨
    ```html
     <meta name='viewport' content='width=device-width, initial-scale=1'>
    ```
    - @media 태그 : 디바이스 종류별로 CSS 따로 디자인가능

## 3일차
- Javascript
    - 스크립트 언어, ECMAScript
    - 웹 브라우저 주로 사용
    - 바닐라스크립트 : 완벽하게 기본에 충실한 자바스크립트
    - 기본적으로 클라이언트(웹 브라우저에서 프론트엔드에 표시) 베이스
    - Node.js : 자바스크립트로 백엔드를 구현(파이썬과 유사)
    - 특징
        - 자료형 선언이 없음, var 변수 선언
        - 인터프리터 언어(not Compile Lang)
        - 확장자.js
        - 속도가 컴파일 언어에 비해서 느림
        - VS Code도 자바스크립트로 만든 앱
        - 문장 끝 ; 은 생략가능, but 최대한 쓸 것
        - 정수와 실수를 구분하지 않음
        - 0으로 나눠도 예외가 발생하지 않음
        - 파이썬과 동일하게 ', " 모두 사용
        - 완전히 동일함을 비교하는 === 연산자
        - 변수선언시 let(일반), var(지역변수), const(상수)
        - HTML 태그와 연계(DOM) 중요
    
    - DOM(Document Object Model)
        - 실행 순서 중요
        - HTMl에 있는 모든 요소를 제어할 수 있음
        - html 애니메이션, 게임, 통신 모두 가능
        - 이벤트 on- 으로 시작
            - onload : 화면이 다 랜더링되면 그 다음 발생
            - onfocus : 객체에 마우스를 클릭해서 포커스가 가면 발생
            - onclick : 객체를 마우스로 클릭하면 발생
            - ondbclick : 더블클릭
            - onmousemove : 마우스를 이동하면 발생
            - onmouseover : 객체 위에 마우스가 올라가면 발생
            - onkeydown, donkeypress : 객체에서 키보드를 타이핑하면 발생
            - ...

    - JQuery
        - 자바스크립트 라이브러리
        - js를 매우 편리하세 사용할 수 있도록 도와주는 서포트 라이브러리
        - 순식간에 웹개발 업계를 장악했던 라이브러리
        - 사용빈도가 줄고는 있지만 아직도 80% 웹사이트가 사용 중
        - js 파일 다운로드 후 사용하거나
        - CDN 링크를 사용하는방법(추천)

##4일차
- HTML + CSS + js(jQuery) 응용
    - jQuery 응용
        - javascript와 jQuery를 혼용해도 상관없음
        - jQuery로 코딩편할때와 javascript가 편할때도 있음
    - BootStrap
        - 오픈소스 CSS 프레임워크
        - 트위터 블루프린트 -> 부트스트랩
        - 현재 전세계에서 가장 각광받는 프레임워크 중 하나
        - CSS를 동작시키기 위해서 Javascript도 포함
        - 소스 다운로드 받아서 사용, CDM으로 링크만 사용(2). 2번이 훨씬 편리
            - 제한된 네트워크에서는 1번
            - 인터넷이 항상 연결된 환경에서는 2번이 편리
        - 핵심
            - Bootstrap은 화면사이즈를 12등분
                - 12를 넘어서면 디자인이 깨짐
            - container 밑에 마치 table처럼 div를 구분해서 사용
            - container > row > col div 태그 클래스 정의
        - 부트스트랩 학습에 시간을 들이는게 아님. Copyleft가 정석
            - https://getbootstrap.com/docs/5.3/getting-started/introduction/ 참조
            - https://getbootstrap.com/docs/5.3/examples/ 스니펫을 활용 추천
            - 무료 테마(템플릿)가 아주 잘되어 있음
                - https://startbootstrap.com/
    - 웹페이지 클로닝
        - 핀터레스트 타입 웹페이지 만들기(진행중)

## 5일차
- HTML + CSS + js(jQuery) 응용
    - 웹페이지 클로닝