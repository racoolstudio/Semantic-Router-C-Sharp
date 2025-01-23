# Semantic-Router-C-Sharp

**Semantic-Router-C-Sharp** is a superfast decision-making layer for your LLMs (Large Language Models) and agents in C#. Instead of relying on slow LLM generations to make tool-use decisions, this router uses the power of **semantic vector space** to make fast decisions by routing requests based on semantic meaning.

This C# version replicates the core features of the original Python Semantic Router, offering the same functionality with C#-specific optimizations.

## Overview

The Semantic Router makes routing decisions based on the **semantic content** of a query, improving efficiency in applications that rely on NLP. It can be used to route requests to different actions or tools depending on the meaning of the user's input, without the need for slow or manual decision-making.

## Features

- Routes decisions based on the **semantic meaning** of user input.
- Superfast decision-making for applications involving LLMs and agents.
- C#-optimized implementation for routing natural language queries.
- Easily integrates with existing C# systems.

## Installation

### Manual Installation

1. Clone the repository:

```bash
git clone https://github.com/yourusername/Semantic-Router-C-Sharp.git
```
2 Build the project:

```bash
dotnet build
```
3 Add the project to your solution or reference the compiled DLL.

## Quickstart

### To get started with the Semantic Router in C#, follow these simple steps.

1. Define Your Routes:
Define a set of **Route objects**. These represent the decision paths the router will use. In this example, we define two routes: one for political discussions and one for casual chitchat.

```csharp
using SemanticRouter.Models;
using SmartComponents.Inference;

Route chitchat = new Route(
    name: "chitchat",
    utterances: new string[] {
        "how's the weather today?",
        "how are things going?",
        "lovely weather today",
        "the weather is horrendous",
        "let's go to the chippy"
    }
);

Route politics = new Route(
    name: "politics",
    utterances: new string[] {
        "isn't politics the best thing ever?",
        "why don't you tell me about your political opinions?",
        "don't you just love the president?",
        "they're going to destroy this country!",
        "they will save the country!"
    }
);

Route[] routes = new Route[] { chitchat, politics };

```
2. Initialize the Route Layer:
The **RouteLayer** handles the decision-making process, routing the input based on its semantic content. You’ll need to instantiate a RouteLayer object and pass in your predefined routes.

```csharp
RouteLayer routeLayer = new RouteLayer();
```

3. Make Semantic Decisions:
Now, you can pass user input to the RouteLayer, which will return the appropriate route based on the semantic meaning of the query.

```csharp
// Example 1: Chitchat query
string c_target = "how are you doing?";
var c_result = routeLayer.GetRoute(c_target, routes);
Console.WriteLine(c_result); // Output: chitchat

// Example 2: Politics query
string p_target = "I think the president is doing a great job";
var p_result = routeLayer.GetRoute(p_target, routes);
Console.WriteLine(p_result); // Output: politics
```
4. Running the Application:
Run the application using the following command:

``bash
dotnet run

```
**Expected Output:**
```bash
chitchat
politics
```

## Contributing
I welcome contributions! If you'd like to help improve this project or add new features, follow these steps:

a. Fork the repo.
b. Create a new branch (git checkout -b feature/your-feature).
c. Commit your changes (git commit -am 'Add new feature').
d. Push to the branch (git push origin feature/your-feature).
e. Open a pull request.

## Acknowledgements
- The original concept was inspired by [Aurelio Labs' Semantic Router (Python)](https://github.com/aurelio-labs/semantic-router).
- Thanks to the open-source community for supporting the development of intelligent routing solutions.


