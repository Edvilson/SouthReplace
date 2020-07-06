# SouthReplace
* A aplicação foi desenvolvida com .Net Core;
* Os testes devem ser executados no visual studio via console, deve ser informada uma ou mais palavras o algoritmo irá substituir cada letra pela letra que segue no alfabeto.<br/> Ex: <b>South System</b>, vai ficar <b>TpvUI TztUfn</b>.
* Caso a palavra contenha caracteres especiais, números ou espaço somente, irá ser apresentada uma mensagem informando que a palavra informada está inválida e questiona se deseja continuar ou não com o teste.
* A aplicação aceita tanto letra maiúscula quanto minúscula, antes de retornar a palavra deformada o algoritmo verifica se tem vogal e passa elas para maiúsculo e também coloca primeira letra da palavra maiúscula.

![South](https://user-images.githubusercontent.com/13906268/86548686-af075a80-bf13-11ea-9b9e-5693bf3bd72b.JPG)

* Foi criada uma classe <b>Deform</b>, nesta implementei a função <b>Deformer</b> que faz toda trativa da palavra informada, com auxílio de outros métodos. Me preocupei em criar a função principal de modo que ficasse mais prático no momento de implementar os testes unitários automatizados.
* Procurei implementar funções e métodos simples, de fácil entendimento e respeitando padrões.
* Nos testes unitários automatizados criei dois métodos <b>DeformIsValid</b>, que testa o retorno correto da função e <b>DeformInValid</b> que testa o retorno incorreto da função.
