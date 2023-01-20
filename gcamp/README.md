<pre>
역사
	- linux에서 c#가 .net를 사용하기 위해서 시작한 것이 mono 프로젝트
	- mobile시장이 성장하면서 c# & .net을 이용해 어떻게 하면 android와 ios에 적용할 수 있을까 고민
		ㄴ각 언어를 C#으로 감싸준 느낌이고, 성능이 살짝 느림
	- 2015년 xamarin forms가 나옴, cross platform으로 나오게 됨 xamarin forms인기를 많이 얻은 시점
	- MS 스마트폰 시장 확장을 위해 xamarin사를 2016년에 2월 인수하고 무료화 오픈함
	
	crossplatform이란?
		- 다양한 컴퓨터 플랫폼 OS에 동작이 가능함
		- smartphone cross platform
			원 소스를 이용해 다양한 모바일 플랫폼에서 동작 가능한 소프트웨어
			각 개발자가 많다면 비용도 많이 들기 때문에 한 번에 처리할 수 있는 개발자가 필요하다
			one source로 만들어서 알아서 할 수 있다면 얼마나 좋을까
		
		- phonegap
			- xamarin이 유행하기 전에 원소스로 기존의 사용하는 언어로 스마트폰 앱을 만들 수 있을까
				ㄴ 여러가지 프레임워크가 등장함, 
			웹페이지를 만드는 기술로 응용프로그램을 만들려함
			빌드를 하면 (윈도우, 안드로이드, 아이폰)앱이 나옴, 취지는 좋음
			ㄴ새로운 기술을 배울 필요없이 해당 기술로 하이브리드 앱을 만들면 됨
			- 각각의 네이티브 앱이 가진 복잡한 내용을 구현할 때 좋지 않음
			adobe에서 인수함
		- titanium -> JS 자체 SDK를 이용해 Cross Platform App개발
		
	xamarin이란?
	android / ios / uwp (universal window platform)
	c#언어로 개발이 가능하기 위해서
	
		c#으로 감쌈 
		android - java
		ios - object c
		uwp - c#
		
	시도는 좋으나 java로 감싼 C#의 API 학습을 해야함
	
	** android, ios, uwp api전부 따로 존재함
	개별 API를 컨버팅한 수준으로 개발자의 스트레스는 오히려 증가함
	
	one source로 다양한 플랫폼을 대응할 수 있음
	</pre>