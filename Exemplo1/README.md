# Exemplo1: Código duplicado


## ERRADO


O exemplo com o codigo errado feito na classe `Processo.cs` na linha `10` mostra uma propriedade da entidade Processo sendo declarada de forma publica, permitindo o acesso direto a ela ao instanciar esse objeto.

No exemplo a classe ´Program.cs´ na linha `14` instancia um `Processo` e acessa diretamente a propriedade DataCancelamento atribuindo um valor a ela.

Com isso o objeto pode ter varios comportamentos na mesma classe como mostra na linha `19`.

## CERTO

O exemplo com o codigo certo na classe `Processo.cs` na linha `13` coloca a palavra reservada `private` antes do `set` o que indica que apenas a classe pode modificar o estado da propriedade.

Para essa modificação é criado a função `AlteraDataCancelamento` para modificar a propriedade.

No exemplo a classe ´Program.cs´ cria uma instancia de um `Processo` na linha `22` onde devemos utilizar o comportamento da própria classe chamando a função `AlteraDataCancelamento` para mudar a data. Veja que nao é possivel mais alterar o processo da classe `Program.cs` apenas dentro da instancia do `Processo`.

Esse comportamento vai manipular apenas estados/propriedades da própria classe mantendo uma coesão em caso de falhas, facilitando a correção para todos os lugares com apenas uma modificaçao local.