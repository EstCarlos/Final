grammar DocumentSpec;

// Parser rules
document: (text | bold | italic | underline | title | heading1 | heading2 | heading3 | nested)+ ;

text: TEXT ;
bold: BOLD (text | italic | underline | title | heading1 | heading2 | heading3 | nested)+ BOLD;
italic: ITALIC (text | bold | underline | title | heading1 | heading2 | heading3 | nested)+ ITALIC ;
underline: UNDERLINE (text | bold | italic | title | heading1 | heading2 | heading3 | nested)+ UNDERLINE ;
title: TITLE TEXT TITEND ;
heading1: HEADING1 TEXT ;
heading2: HEADING2 TEXT ;
heading3: HEADING3 TEXT ;
nested: NESTED ;

// Lexer rules
BOLD : '$' ;
ITALIC : '~' ;
UNDERLINE : '++' ;
TITLE : '>' ;
TITEND: '<' ;
HEADING1 : '^' ;
HEADING2 : '^^' ;
HEADING3 : '^^^' ;
NESTED : (BOLD | ITALIC | UNDERLINE | TITLE | HEADING1 | HEADING2 | HEADING3 | TEXT)+ ;

TEXT :   WORD (WS WORD)* ;
WORD :   [A-Za-z0-9]+ ;

WS : [ \t\r\n]+ -> skip ;

//Comiiit