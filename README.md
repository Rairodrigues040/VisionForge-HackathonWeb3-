# 🥽 VisionSurge

> Simulação imersiva em realidade virtual para treinamento de instrumentação cirúrgica.

![Status](https://img.shields.io/badge/status-em%20desenvolvimento-blue)
![Unity](https://img.shields.io/badge/Unity-6000.3.13f1-black)
![Platform](https://img.shields.io/badge/Platform-Meta%20Quest%202%20%7C%203-green)
![Language](https://img.shields.io/badge/C%23-.NET-purple)

---

## 📖 Sobre o Projeto

O **VisionSurge** é uma plataforma de treinamento em Realidade Virtual desenvolvida para capacitar instrumentadores cirúrgicos em um ambiente seguro, imersivo e controlado.
O sistema simula atividades de instrumentação cirúrgica permitindo que estudantes e profissionais pratiquem repetidamente sem riscos ao paciente e sem depender da disponibilidade de centros cirúrgicos reais.
Desenvolvido durante um Hackathon com foco em inovação para a área da saúde.


## 🎯 Problema resolvido

O treinamento tradicional de instrumentação cirúrgica apresenta diversos desafios. O aprendizado ocorre principalmente por observação, com poucas oportunidades 
de prática em um ambiente seguro. Além disso, os custos operacionais são elevados e há uma forte dependência de ambientes reais para o treinamento. 
A repetição de procedimentos é limitada, o que dificulta o desenvolvimento de habilidades, e existe o risco de erros durante o processo de aprendizagem.


## 💡 Solução

O **VisionSurge** utiliza Realidade Virtual para criar cenários de treinamento que tornam o aprendizado mais seguro, prático e eficiente. 
Por meio de simulações cirúrgicas imersivas, os profissionais podem praticar procedimentos sem riscos ao paciente, repetir atividades 
quantas vezes forem necessárias e receber feedback imediato sobre seu desempenho. Além disso, a plataforma oferece métricas detalhadas 
para acompanhamento da evolução e promove uma aprendizagem baseada na experiência prática.

## 👨‍⚕️👩‍⚕️Público-alvo

O projeto foi desenvolvido para atender estudantes da área da saúde, instrumentadores cirúrgicos em formação e 
profissionais que buscam aprimorar suas habilidades práticas. Também é direcionado a cursos técnicos, 
instituições de ensino, hospitais, clínicas e centros de treinamento que necessitam de soluções eficazes para capacitação. 
A plataforma permite que equipes pratiquem o reconhecimento, a seleção e a entrega correta de instrumentos cirúrgicos em um ambiente 
seguro e controlado, contribuindo para o desenvolvimento técnico e a redução de erros durante o aprendizado.

## ᯅ Experiência imersiva

No ambiente virtual, o usuário assume uma perspectiva em primeira pessoa e interage com objetos presentes em um centro cirúrgico.

O fluxo principal da experiência é:

1. o usuário entra no ambiente cirúrgico virtual;
2. o médico solicita um instrumento por áudio;
3. o usuário localiza o instrumento correto;
4. o usuário pega o instrumento com controle VR;
5. o instrumento é entregue ao médico;
6. o sistema valida se a entrega está correta ou incorreta.


---

## 🚀 Funcionalidades
- Ambiente cirúrgico 3D navegável;
- Simulação em primeira pessoa;
- Interação com instrumentos cirúrgicos;
- Solicitação de instrumentos por áudio;
- Entrega de instrumentos ao médico;
- Validação de acerto ou erro;
- Suporte estrutural a XR;
- Configuração para uso com simulador de óculos VR no Unity.

---
## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão | Função |
|------------|---------|---------|
| **Android (Meta Quest OS)** | 2.4 | Plataforma alvo de deploy |
| **Assets 3D em formato FBX** | — |Modelagem e representação visual dos instrumentos cirúrgicos e elementos do cenário |
| **C#** | — | Linguagem de programação dos scripts de interatividade |
| **Meta XR SDK** | 201.0.0 | SDK para interação VR no Meta Quest |
| **OpenXR** | 1.16.1 | Camada de abstração multiplataforma para XR |
| **TextMesh Pro** | 3.2.0-pre.15 | Renderização de texto de alta qualidade nos totens |
| **Unity** | 6000.3.13f1 (Unity 6) | Engine principal de desenvolvimento |
| **Unity Input System** | 1.18.0 | Sistema de entrada para controles do Quest |
| **Universal Render Pipeline (URP)** | 17.3.0 | Pipeline de renderização otimizado para VR |
| **Unity Input System** | — | Sistema de entrada para controles do Quest e captura de interações do usuário |
| **XR Plugin Management** | 4.5.4 | Gerenciamento e integração dos provedores XR utilizados pelo projeto |

### Implementadas

- ✅ Sistema de solicitação de instrumentos
- ✅ Identificação de instrumentos cirúrgicos
- ✅ Feedback por áudio
- ✅ Tutorial guiado
- ✅ Avaliação de acertos e erros
- ✅ Ambientes imersivos em VR
---

## 📂 Estrutura do Projeto

```text
VisionSurge/
├── .vscode/
├── Assets/
│   ├── Audio/
│   ├── Oculus/
│   ├── Plugins/
│   ├── prefabs/
│   ├── Resources/
│   ├── Scenes/
│   ├── Script/
│   ├── Settings/
│   ├── TextMesh Pro/
│   ├── texture/
│   ├── XR/
│   └── XRI/
├── Packages/
├── ProjectSettings/
├── .gitattributes
├── .gitignore
└── VisionForge.slnx
```
---

## 🎬 Cena principal

A cena principal do projeto está localizada em:

```txt
Assets/Scenes/SampleScene.unity
```

## 🏗️ Arquitetura e Scripts

Os scripts do projeto estão localizados em:

```txt
Assets/Script/
```

Principais arquivos:

```txt
AreaEntrega.cs
AreaProximidade.cs
Instrumentos.cs
MedicoPedido.cs
NarraçãoTutorial.cs
TipoInstrumento.cs
```
### Descrição geral dos scripts

| Script                | Função no projeto                                                                              |
| --------------------- | ---------------------------------------------------------------------------------------------- |
| `AreaEntrega.cs`      | Controla a lógica relacionada ao momento de entrega do instrumento.                            |
| `AreaProximidade.cs`  | Gerencia a detecção de proximidade entre usuário, objetos e áreas de interação.                |
| `Instrumentos.cs`     | Representa os instrumentos disponíveis na simulação.                                           |
| `MedicoPedido.cs`     | Controla os pedidos feitos pelo médico durante a experiência.                                  |
| `NarraçãoTutorial.cs` | Estrutura relacionada a narração/áudio, embora a versão atual seja descrita como sem tutorial. |
| `TipoInstrumento.cs`  | Define ou organiza os tipos de instrumentos utilizados na validação.                           |

---
## Assets 3D

Os modelos 3D estão localizados principalmente em:

```txt
Assets/prefabs/
```

Entre os assets utilizados estão:

- bisturi;
- pinça;
- afastador;
- tesoura;
- bandeja cirúrgica;
- cama/leito;
- carrinho médico;
- monitor cardíaco;
- luminária cirúrgica;
- armários;
- portas;
- cadeira de rodas;
- elementos de parede, piso e estrutura hospitalar.

Alguns modelos 3D utilizados no projeto são assets externos de apoio, e foram respeitadas suas respectivas licenças e autorias.

---

## Como executar o projeto

### Pré-requisitos

Antes de abrir o projeto, é necessário ter instalado:

- Unity Hub;
- Unity 6000.3.13f1 ou versão compatível;
- suporte a XR Plugin Management;
- suporte ao Unity Input System;
- ambiente configurado para simulação VR no Unity.


### Passo a passo

1. Acesse o repositório:

```bash
git clone https://github.com/SEU-USUARIO/VisionSurge.git
```

2. faça o download do arquivo .exe.

3. Clique duas vezes ou, com o botão direito, executar como administrador.

4. participe do treinamento.

---
## Demonstração

### Vídeo demo

```txt
https://youtube.com/SEU-LINK-VIDEO-DEMO
```

### Vídeo pitch

```txt
https://youtube.com/SEU-LINK-VIDEO-PITCH
```

### Slides da apresentação

```txt
https://drive.google.com/SEU-LINK-SLIDES
```
---
## ≠ Diferenciais do projeto

- Simulação prática em ambiente cirúrgico;
- Uso de realidade virtual para treinamento seguro;
- Interação com instrumentos médicos;
- Validação de acerto e erro;
- Aplicação em formação profissional;
- Experiência mais envolvente do que uma apresentação tradicional;
- Possibilidade futura de expansão para novos procedimentos, níveis e instrumentos.

---

## Limitações da versão atual

Por se tratar de um MVP, esta versão possui algumas limitações:

- execução atual apenas em simulador VR no Unity;
- sem tutorial inicial;
- escopo limitado a interações básicas com instrumentos;
- ambiente e assets ainda em estágio de protótipo;
- sem sistema de login, banco de dados ou métricas avançadas.

---

## 📈 Possíveis melhorias futuras

- Geração de build para Meta Quest;
- Inclusão de tutorial guiado;
- Adição de novos instrumentos cirúrgicos;
- Sistema de pontuação;
- Registro de tempo de resposta;
- Histórico de acertos e erros;
- Níveis de dificuldade;
- Feedback visual e sonoro mais completo;
- Painel de desempenho para instrutores;
- Expansão para outros cenários de treinamento hospitalar.

---

## 🤖 Uso de inteligência artificial generativa

Durante o desenvolvimento e documentação do projeto, foram utilizadas ferramentas de inteligência artificial generativa como apoio.
Ferramentas utilizadas:

- ChatGPT.

Finalidades de uso:
- apoio na organização da documentação;
- estruturação do README;
- revisão textual;
- apoio na clareza da proposta;
- organização da narrativa do projeto para apresentação.

A IA foi utilizada como ferramenta auxiliar. As decisões de projeto, implementação, organização da experiência e validação final permaneceram sob responsabilidade da equipe.

---

## ©️ Créditos e assets externos

O projeto utiliza assets 3D de apoio em formato FBX para compor o ambiente cirúrgico e seus objetos.
Quando aplicável, os modelos externos foram creditados e utilizados respeitando suas respectivas licenças de uso e autorias.

---

## 🤝 Equipe

**Equipe VisionForge**

| Integrante                 | Participação                                             |
| -------------------------- | -------------------------------------------------------- |
| Carlos André Távora Soares | Desenvolvimento, documentação e estruturação da proposta |
| Raí Rodrigues              | Desenvolvimento, apoio técnico e documentação            |
| Eduardo martins            | Desenvolvimento, apoio técnico e documentação            |
| Ismael Lopes               | Desenvolvimento, apoio técnico e documentação            |
---

## 🛍️ Produto

**VisionSurge**

Uma experiência imersiva para treinar reconhecimento e entrega de instrumentos cirúrgicos em ambiente virtual.

---

## 📊 Status do projeto

```txt
Versão: 1.0
Status: MVP funcional em ambiente Unity
Execução: Simulador VR no Unity
Build final: não disponível nesta versão
```

---

## 🧾Licença
Este projeto foi desenvolvido para fins acadêmicos e demonstrativos no contexto do HackWeb / ExpoVerse.
A definição de licença pública poderá ser ajustada posteriormente pela equipe.

>VisionSurge — treinar antes do ambiente real.
