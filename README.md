<div align="center">
  <table>
    <tr>
      <td align="center">
        <!-- Link para o Certificado -->
        <a href="https://cursos.alura.com.br/certificate/gustavo-vieira17/arquitetura-dotnet-descomplicando-clean-architecture">
          <img loading="lazy" width="128px" src="https://www.alura.com.br/assets/api/cursos/arquitetura-dotnet-descomplicando-clean-architecture.svg" />
        </a>
        <h4>Curso</h4>
      </td>
      <td align="center">
        <!-- Link para o Certificado -->
        <a href="https://cursos.alura.com.br/certificate/gustavo-vieira17/arquitetura-dotnet-descomplicando-clean-architecture">
          <img loading="lazy" width="128px" src="https://static.vecteezy.com/system/resources/previews/028/293/920/original/trophy-icon-3d-rendering-illustration-png.png" />
        </a>
        <h4>Certificado</h4>
      </td>
    </tr>
  </table>
  <h1>Arquitetura .NET: descomplicando a Clean Architecture 🦠</h1>
</div>
<p align="right">
  <img loading="lazy" src="https://img.shields.io/badge/CARGA_HORARIA-10_HORAS-red?style=for-the-badge"/>
  <img loading="lazy" src="http://img.shields.io/static/v1?label=STATUS&message=FINALIZADO!&color=GREEN&style=for-the-badge"/>
</p>

<div>
  <h2>Conhecimentos adquiridos em Arquitetura .NET e praticados em desenvolvimento:</h2>
  <ul>
    <li><h3>Estruturação de projetos .NET seguindo os princípios da Arquitetura Limpa.</h3></li>
    <li><h3>Organização do código em camadas de Domínio, Aplicação, Interface e Infraestrutura.</h3></li>
    <li><h3>Aplicação de princípios e regras da Arquitetura Limpa para criar softwares eficientes e escaláveis.</h3></li>
    <li><h3>Uso de boas práticas de programação orientada a objetos em C#, com foco em abstrações.</h3></li>
    <li><h3>Domínio de técnicas e estratégias para refatoração de código.</h3></li>
    <li><h3>Criação de códigos mais legíveis, limpos e fáceis de manter.</h3></li>
    <li><h3>Aplicação de boas práticas de testes para garantir a qualidade das soluções.</h3></li>
  </ul>

  <ul> 
    | Definição de arquitetura |
    Benefícios das arquiteturas |
    MVC como modelo de estudo |
    Camada de Domínio |
    Princípio da Testabilidade |
    Camada de Interface |
    Camada de Aplicação |
    Camada de Infra |
    Organização da Solução |
    Comunicação entre camadas |
    Dependência entre camadas |
    Abstrações (ex. Repositório) |
    Nova funcionalidade Consulta com Arquitetura Limpa |
  </ul>
</div>

<br>
<div align="center">
  <h1> 📚 Anotações: </h1>
  <img width="512px" src="https://raw.githubusercontent.com/GustavoVieiraa/Arquitetura-.NET-descomplicando-a-Clean-Architecture/refs/heads/main/archives/abstra%C3%A7%C3%A3o%20da%20Arquitetura%20Limpa.png">

  <h1>
    Arquitetura de Software é (...) a divisão em componentes,
    o arranjo desses componentes e as formas como eles se comunicam entre si.
  </h1>
<br>
<ul>
  <li>
    <h3>
      (1°) Camada de domínio / Regra de negócio
      A camada de Domínio na Arquitetura Limpa é o núcleo da aplicação,
      representando as regras e conceitos que guiam o funcionamento do sistema e do negócio em si.
    </h3>
  </li>
  <li>
    <h3>(2°) Camada de Interface de entrada e saída (Adaptadores de Interface) (DTOs)</h3>
  </li>
  <li>
    <h3>(3°) Camada de Aplicação / Camada Use Cases (casos de uso)</h3>
  </li>
  <li>
    <h3>(4°) Camada de Infraestrutura (Frameworks e Drivers)</h3>
  </li>
</ul>

<br>

<ul> <h2>🐠 TDD (Test-Drive-Design) ou (Test-Drive-Development)</h2>
  <h3>
    Com um desenvolvimento orientado a triple AAA (Arrange -> Act -> Assert) / (Cenário / Ação / Resultado)
    Seguimos um fluxo RED-GREEN-REFACTOR
  </h3>
  <li>RED 🔴 Escrevemos um teste para uma funcionalidade a qual iremos implementar <br> (ELE DEVE FALHAR)</li>
  <li>
    GREEN 🟢 Após essa falha, implementamos a nossa funcionalidade e executamos o nosso teste, porém dessa vez o teste passa com sucesso.
  </li>
  <li>
    REFACTOR 🔃 Com os testes funcionando, chegamos ao stop refactor.
    Onde procuramos pontos a melhorar e aplicar boas práticas de programação.
  </li>
</ul>

<br>

<ul><h1>🥪 Camadas:</h1>
  <h2>O que Arquitetura Limpa praticamente sintetiza é: As camadas internas não conversam com camadas externas.</h2>
  <h3>Camada de Domínio (Anti-Social) não conversa com ninguém.</h3>
  <h3>Camada de Aplicação -> Camada de Domínio.</h3>
  <h3>Camada de Interface -> Camada de Aplicação -> Camada de Domínio.</h3>
  <h3>Camada de Infraestrutura -> Camada de Interface -> Camada de Aplicação.</h3>
</ul>

</div>
