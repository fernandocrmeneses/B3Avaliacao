ö
KC:\Projetos\B3\AvaliacaoB3\src\B3.Avaliacao.Core\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str ,
), -
]- .
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str .
). /
]/ 0
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *ø
QC:\Projetos\B3\AvaliacaoB3\src\B3.Avaliacao.Core\ObjetosDominio\ExcecaoDominio.cs
	namespace 	
B3
 
. 
	Avaliacao 
. 
Core 
. 
ObjetosDominio *
{ 
public		 

class		 
DominioException		 !
:		" #
	Exception		$ -
{

 
public 
DominioException 
(  
string  &
message' .
). /
:0 1
base2 6
(6 7
message7 >
)> ?
{ 	
}
 
} 
} µ
MC:\Projetos\B3\AvaliacaoB3\src\B3.Avaliacao.Core\ObjetosDominio\Validacoes.cs
	namespace 	
B3
 
. 
	Avaliacao 
. 
Core 
. 
ObjetosDominio *
{ 
public		 

static		 
class		 

Validacoes		 "
{

 
public 
static 
void "
ValidarSeValorForMenor 1
(1 2
decimal2 9
valor: ?
,? @
decimalA H
valorMinimoI T
,T U
stringV \
mensagem] e
)e f
{ 	
if 
( 
valor 
< 
valorMinimo #
)# $
{ 
throw 
new 
DominioException *
(* +
mensagem+ 3
)3 4
;4 5
} 
} 	
} 
} 