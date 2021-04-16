grammar calc;
logical_operations : bool ((('&'|'|') bool)+)?
	;

bool : addition_subtraction ((('>'|'<'|'>='|'<='|'==') addition_subtraction)+)?
	;
addition_subtraction : mult_div ((('+'|'-') mult_div)+)?
     ;
     
mult_div : exponent ((('*'|'/') exponent)+)?
     ;
     
exponent : expr ('^' exponent)?
       ;
       
expr : float_num
  | '(' logical_operations ')'
  | '-' mult_div
  | '!' '(' logical_operations ')'
  | EOF
  ;
  
float_num : num ('.' num)?
          ;
num : INT ((INT)+)?
    ;

INT :	'0'..'9'+
    ;
    
WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        )
    ;

