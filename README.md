MakeASCIIRandomString Class for Visual Studio, Version 2.0
======================================================

Class designed to make strings of random characters in a really fast fashion + WinForm test program

Files Info:
---------------

`MakeASCIIRandomString.cs`  Class source file<br/>
`TestApp.cs`                WinForm Demo

Usage:
----------

`MakeASCIIRandomString mars = new MakeASCIIRandomString();`

Instantiate mars obj


Single type Methods:
-------------------------

`LowerCaseLetters(int length)`                  Make a string only of lower case letters<br/>
`UpperCaseLetters(int length)`                  Make a string only of upper case letters<br/>
`Symbols(int length)`                           Make a string only of ASCII Symbols<br/>
`Numbers(int length)`                           Make a string only of numbers<br/>

Mixed type Methods:
------------------------

`MixLetters(int length)`                        Make a string of mixed lower case and upper case letters<br/>
`MixNumbersAndSymbols(int length)`              Make a string mixing numbers and symbols<br/>
`MixLowerCaseLettersAndSymbols(int length)`     Make a string mixing lower case letters and symbols<br/>
`MixNumbersAndLowerCaseLetters(int length)`     Make a string mixing lower case letters and numbers<br/>
`MixUpperCaseLettersAndSymbols(int length)`     Make a string mixing upper case letters and symbols<br/>
`MixNumbersAndUpperCaseLetters(int length)`     Make a string mixing upper case letters and numbers<br/>
`MixAllKindOfLettersAndSymbols(int length)`     Make a string mixing upper case, lower case letters and symbols<br/>
`MixAllKindOfLettersAndNumbers(int length)`     Make a string mixing upper case, lower case letters and numbers<br/>
`MixAll(int length)`                            Make a string of everything<br/>

Patter type Methods:
-------------------------

`MixByPattern(string pattern)`                  Build your random mixed string<br/>

l -> lower case letter<br/>
u -> upper case letter<br/>
n -> number<br/>
s -> symbol<br/>

*Example:*

`MixByPattern(llusnlsn)` -> kjO$9g£8</br>

ChangeLog:
-------------

**(a lot of time ago)**<br/>
*Version: 1.0*<br/>
Initial release based on a single method and a big switch (brrr)<br/>

**2017/12/23**<br/>
*Version: 2.0*<br/>
Replaced the switch with lot of documented methods for the joy of Intellisense<br/>
Added `MixByPattern` method
Added `MixAllKindOfLettersAndNumbers` method
Added "copy string" function in Test App