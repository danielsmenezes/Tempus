# ⏱️ Tempus - Speaker Countdown Timer

Tempus is a lightweight, highly customizable countdown timer application developed in **C# .NET 10** using **Windows Forms**. 

It was specifically designed for **small churches, local events, and lectures** to help manage speaker time effectively. The application provides a control panel on the primary monitor for the operator, while automatically projecting a clean, synchronized, and distraction-free countdown display on a secondary monitor (facing the speaker).

## ✨ Core Use Cases
* **Churches & Ministries:** Keep sermons and announcements running on schedule.
* **Small Events & Meetups:** Help speakers and presenters stick to their allotted time slots.
* **Live Streams:** Manage internal segmented times for production teams.

## 🚀 Features
* **Dual-Monitor Support:** Automatically detects available screens and casts the timer to the secondary monitor without dragging windows around.
* **Smart Visual Alerts (New!):** * Set a custom threshold (in minutes) for the timer text to flash red, gently warning the speaker to wrap up.
  * **End-of-Time Highlight:** Optional high-contrast alert mode (Red background, Yellow text) when the timer hits zero.
* **Speaker-Friendly Display:** Clean, distraction-free UI that only shows what the speaker needs to see.
* **Persistent Configuration:** User preferences are securely saved locally via `System.Text.Json`.
* **Highly Customizable:**
  * Adjustable font sizes and styles (Bold/Regular).
  * Time format selection (`hh:mm:ss`, `hh:mm`, or strictly `mm:ss` for sessions over an hour, like `120:00`).
  * Theme support (Light and Dark modes to match venue lighting).
* **Hidden Debug Mode:** Built-in debug tag in the configuration file for advanced troubleshooting.

## 🛠️ Technologies Used
* C#
* .NET 10
* Windows Forms (WinForms)
* System.Text.Json (for serialization)

## 📦 How to Run
1. Make sure you have the [.NET 10 SDK](https://dotnet.microsoft.com/) installed.
2. Clone this repository: `git clone https://github.com/your-username/Tempus.git`
3. Open the `.sln` file in Visual Studio.
4. Build and run the project (F5).

---

# ⏱️ Tempus - Cronômetro para Palestrantes e Eventos

Tempus é um aplicativo de contagem regressiva leve e altamente customizável, desenvolvido em **C# .NET 10** utilizando **Windows Forms**.

Foi projetado especificamente para **pequenas igrejas, eventos locais e palestras** para ajudar no controle de tempo de quem está no palco. O aplicativo fornece um painel de controle no monitor principal para o operador, enquanto projeta automaticamente uma tela limpa, sincronizada e sem distrações com o cronômetro em um monitor secundário (voltado para o palestrante).

## ✨ Principais Casos de Uso
* **Igrejas e Ministérios:** Manter pregações e avisos dentro do tempo programado.
* **Pequenos Eventos e Meetups:** Ajudar palestrantes e apresentadores a não ultrapassarem seus horários.
* **Transmissões ao Vivo:** Gerenciar blocos de tempo internos para a equipe de produção.

## 🚀 Funcionalidades
* **Suporte a Múltiplos Monitores:** Detecta automaticamente as telas disponíveis e envia o relógio para o monitor secundário, sem precisar arrastar janelas.
* **Alertas Visuais Inteligentes (Novo!):** * Defina com quantos minutos de antecedência o relógio deve piscar em vermelho, avisando o palestrante para concluir.
  * **Destaque ao Zerar:** Modo opcional de alto contraste (Fundo Vermelho, Letras Amarelas) para chamar atenção máxima quando o tempo esgota.
* **Tela Focada no Palestrante:** Interface limpa e sem distrações, mostrando apenas a informação necessária.
* **Configuração Persistente:** As preferências do usuário são salvas localmente de forma segura via `System.Text.Json`.
* **Altamente Customizável:**
  * Tamanho e estilo de fonte ajustáveis.
  * Seleção de formato de tempo (`hh:mm:ss`, `hh:mm`, ou estritamente `mm:ss` para sessões com mais de uma hora, como `120:00`).
  * Suporte a temas (Modos Claro e Escuro para combinar com a iluminação do local).
* **Modo Debug Oculto:** Tag de debug embutida no arquivo de configuração para testes avançados.

## 🛠️ Tecnologias Utilizadas
* C#
* .NET 10
* Windows Forms (WinForms)
* System.Text.Json (para serialização)

## 📦 Como Executar
1. Certifique-se de ter o [.NET 10 SDK](https://dotnet.microsoft.com/) instalado.
2. Clone este repositório: `git clone https://github.com/seu-usuario/Tempus.git`
3. Abra o arquivo `.sln` no Visual Studio.
4. Compile e execute o projeto (F5).
