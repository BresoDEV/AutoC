# Automação com C#

## Visão Geral
Este projeto contém uma classe para automação de tarefas utilizando interações com teclado e mouse. Ele permite interpretar comandos a partir de um arquivo de texto e executar ações como mover o mouse, clicar, rolar a tela e digitar textos.

## Estrutura do Código
O código é estruturado dentro do namespace `Automacao` e contém a classe `auto`, responsável por interpretar comandos e executar ações de automação.

## Funcionalidades

### Interpretação de Código
O método `interpretarCodigo(string arquivo)` lê um arquivo contendo comandos e executa as ações correspondentes.

Comandos suportados:
- `definir_delay X;` → Define um tempo de espera (`X` em segundos).
- `mover_mouse X Y;` → Move o cursor do mouse para as coordenadas (`X`, `Y`).
- `mover_mouse_relativo X Y;` → Move o cursor do mouse relativamente à posição atual.
- `digitar_teclado "Texto";` → Digita o texto especificado.
- `scroll_baixo X;` → Rola a tela para baixo `X` vezes.
- `scroll_cima X;` → Rola a tela para cima `X` vezes.
- `click_mouse_esquerdo_padrao;` → Clique esquerdo do mouse.
- `click_mouse_direito_padrao;` → Clique direito do mouse.
- `click_mouse_esquerdo_sem_soltar;` → Pressiona o botão esquerdo do mouse sem soltar.
- `click_mouse_direito_sem_soltar;` → Pressiona o botão direito do mouse sem soltar.
- `soltar_click_mouse_esquerdo;` → Solta o botão esquerdo do mouse.
- `soltar_click_mouse_direito;` → Solta o botão direito do mouse.
- `duplo_click_mouse;` → Realiza um duplo clique do mouse.
- `ctrlC;` → Copia (`Ctrl + C`).
- `ctrlV;` → Cola (`Ctrl + V`).
- `AltTab;` → Alterna entre janelas (`Alt + Tab`).
- `CTRL + tecla;` → Simula a combinação `Ctrl + tecla`.

### Métodos para Automação

#### Manipulação do Mouse
- `mover_mouse(int x, int y)` → Move o cursor do mouse.
- `mover_mouse_relativo(int x, int y)` → Move o cursor do mouse relativamente à posição atual.
- `click_mouse_esquerdo_padrao()` → Executa um clique esquerdo.
- `click_mouse_direito_padrao()` → Executa um clique direito.
- `click_mouse_esquerdo_sem_soltar()` → Pressiona o botão esquerdo sem soltar.
- `click_mouse_direito_sem_soltar()` → Pressiona o botão direito sem soltar.
- `soltar_click_mouse_esquerdo()` → Solta o botão esquerdo.
- `soltar_click_mouse_direito()` → Solta o botão direito.
- `duplo_click_mouse()` → Executa um duplo clique.
- `scroll_baixo(int linhas)` → Rola a tela para baixo.
- `scroll_cima(int linhas)` → Rola a tela para cima.

#### Manipulação do Teclado
- `digitar_teclado(string texto)` → Simula a digitação de um texto.
- `ctrlC()` → Simula `Ctrl + C`.
- `ctrlV()` → Simula `Ctrl + V`.
- `AltTab()` → Alterna entre janelas.
- `ctrl(string tecla)` → Simula `Ctrl + tecla`.

### Mapeamento de Teclas
O código contém um `enum teclas`, que define códigos de teclas virtuais (`VK_*`), permitindo mapear diferentes teclas do teclado.

## Dependências e Bibliotecas Utilizadas
- `System.Runtime.InteropServices` → Para chamadas à API do Windows.
- `System.Threading` → Para manipulação de tempo (`Thread.Sleep`).
- `System.Windows.Forms` → Para interações com teclado e mouse.

## Observações Importantes
- O código depende da API do Windows (`user32.dll`) para simular eventos de entrada.
- Pode ser necessário executar como administrador para garantir permissões adequadas.
- O tempo de espera (`tempoDelay`) pode ser ajustado para evitar que ações sejam executadas muito rapidamente.

## Como Utilizar
1. Criar um arquivo de texto contendo os comandos descritos na seção **Comandos Suportados**.
2. Executar o método `interpretarCodigo("caminho/do/arquivo.txt")`.
3. O programa irá processar o arquivo e executar os comandos automaticamente.

## Possíveis Melhorias
- Implementar suporte a mais comandos.
- Criar uma interface gráfica para facilitar a automação.
- Adicionar suporte a scripts mais avançados.

---

Este documento fornece um resumo detalhado do funcionamento do código e suas funcionalidades.
