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
- Javascript