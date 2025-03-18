# Prova Desenvolvedor Multimidia

Bem-vindo a prova prática para a vaga de Desenvolvedor Multimidia no SENAI Soluções Digitais. Ficamos felizes no seu interesse pela vaga, e desejamos uma ótima prova.  
Leia com atenção toda a documentação com os requisitos da prova que foi enviado a você e tente desenvolver o máximo que puder, mesmo que tenha que pular alguma etapa, desde que com qualidade e seguindo as regras de negócio.  
  
Lembrando que a configuração da prova fica a cargo do candidato, a realizar de acordo com os requisitos repassados ao candidato.  
  
Registrar nesse arquivo o que foi realizado da prova, as tecnologias utilizadas, o que não foi possível fazer e alguma observação que achar importante.  

# Instalação

Para rodar o projeto, é necessário:
1. Instalar Unity 2022.3.38f1 (você pode baixar por [aqui](https://unity.com/pt/releases/editor/archive))
2. Faça o clone do projeto da nuvem no diretório local
3. Abra o Unity Hub
4. Adicione o projeto no Unity Hub (após clonar totalmente o projeto)
5. Abra o projeto
6. Vá na pasta: "Assets > _Structure > _Scenes > Gameplay"
7. PLAY para rodar o projeto

# Como jogar

https://github.com/user-attachments/assets/d65f085c-6b1e-46a4-ad46-891896eb1755


## Head Set
- WASD - Mover personagem
- Mouse - Girar câmera
- T - Alternar entre controle XR (esquerdo) e headset
- Y - Alternar entre controle XR (direito) e headset

## Controle XR (Esquerdo)
- WASD - Mover personagem
- Mover Mouse - Girar controle XR (esquerdo)
- Mouse (clique esquerdo) - interagir
- T - Alternar entre controle XR (esquerdo) e headset
- y - Alternar entre controle XR (direito) e headset

## Controle XR (Direito)
- IJKL - Mover personagem
- Mover Mouse - Girar controle XR (direito)
- T - Alternar entre controle XR (esquerdo) e headset
- Y - Alternar entre controle XR (direito) e headset


# Práticas usadas

- Foi usado o conceito de eventos, fazendo com que os scripts e as funções trabalhem isoladamente, isso faz com que a manutenção, adaptação e escalabilidade fique mais fáceis.
- Canvas World Space foi utilizado em cada peça do circuito.
- Lógica foi reutilizada entre as peças dos circuitos, para não haver rendundância de repetição de código.

# Desejo de implementação

- Criação de múltiplos "sockets" em uma única peça, criando ramificações dos cabos, fontes de energia, etc. Que fosse possível criar um circuito complexo. (embora tenha os multiplos "sockets" e logica base para criação de infinitas peças, não há a logica para gerenciar).

# Desafios

- Foi implementado o sistema VR, mas também era o primeiro contato e experiência com VR, então levou mais tempo para saber como manusear o plugin. E também não havia conhecimento sobre qual o plugin VR correto para implementar no projeto, o que levou a uma análise mais longa.
- Não ter certeza se o projeto funciona perfeitamente para VR, pois não há o hardware para testar em versão "build" ou não ter conhecimento técnico suficiente nessa área (VR) para confirmar funcionalidade estável do plugin utilizado.
- Não foi possível desativar determinados botões de interação do plugin XR Toolkit, trazendo entradas de teclado desnecessárias durante a execução do projeto

# Assets usados

[Magic Effects FREE](https://assetstore.unity.com/packages/vfx/particles/spells/magic-effects-free-247933)

[TOOLKIT vol.2 Sound Pack Bundle](https://assetstore.unity.com/packages/audio/sound-fx/toolkit-vol-2-sound-pack-bundle-198011)

- XR Interaction Toolkit (Package Manager - Unity Registry)
- XR Core Utilities (Package Manager - Unity Registry)
- XR Legacy Input Helpers (Package Manager - Unity Registry)
- XR Plugin Management (Package Manager - Unity Registry)
- Text Mesh Pro (TMP) (Package Manager - Unity Registry)
