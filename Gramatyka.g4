grammar Gramatyka;

prog: ( (statement | function)? (NEWLINE) )* ;

block: ( statement? NEWLINE )*  ;

statement: PRINT '(' value ')'                  #print
       | ID '=' value                           #assign
       | ID '=' arithmeticExpr                  #exprAssign
       | ID'[' TYPE INT']'                       #vectDeclaration
       | ID'['INT']' '=' value                  # vectAssign
       | ID'['INT']' '=' arithmeticExpr         # vectExprAssign
       | ID '=' '['numbers']'                   #vectAllAssign
       | READINT '(' value ')'                     #readInt
       | READREAL '(' value ')'                    #readReal
       | ID '()'                                #call
       | IF equal '{' blockIf '}' 		        #if
       | WHILE condition '{' block '}'		    #while
    ;

value: ID
     | STRING 
     | INT 
     | REAL 
     | vect
     ;

vect : ID'['INT']' ;

numbers: number (',' number)*;
number: INT | REAL ;

TYPE : 'INT' | 'REAL' ;

arithmeticExpr: expr ( ( ADD | SUB )  expr )* ;

expr: element ( ( MUL | DIV ) element )* ;

element: LP arithmeticExpr RP   
       | INT                    
       | REAL                   
       | ID                     
       | ID'['INT']'
    ;


function: FUNCTION ID '()' '{' block '}' ;
equal: ID '==' INT  ; 
blockIf: block ;

condition: ID ;

LP: '(' ;
RP: ')' ;
ADD: '+' ; 
SUB: '-' ;
MUL: '*' ;
DIV: '/' ;

WHILE: 'while' ;
IF: 'if' ;
FUNCTION: 'func' ;
READREAL: 'ReadReal' ;
READINT: 'ReadInt' ;
PRINT: 'Print' ;

STRING: '"' ( ~('\\'|'"') )* '"' ;
ID: ('a'..'z'|'A'..'Z')+ ;
INT: SUB? '0'..'9'+ ;
REAL: SUB? '0'..'9'+'.''0'..'9'+  ;
NEWLINE: '\r'? '\n' ;
WHITESPACE : ' ' -> skip ;
COMMENT : '//' ~ [\r\n]* -> skip ;
