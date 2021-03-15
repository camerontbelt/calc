grammar calc;

expr : num ('*'|'/') num
     | num ('+'|'-') num;
num : INT (INT)+;
INT : [0-9]+;