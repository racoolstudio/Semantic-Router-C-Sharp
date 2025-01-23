using SemanticRouter.Models;
using SmartComponents.Inference;



Route chitchat = new Route(
    name:"chitchat",
    utterances: [
         "how's the weather today?",
        "how are things going?",
        "lovely weather today",
        "the weather is horrendous",
        "let's go to the chippy",

        ]
    );

Route politics = new Route(
    name : "politics",
    utterances : [
        "isn't politics the best thing ever",
        "why don't you tell me about your political opinions",
        "don't you just love the president",
        "they're going to destroy this country!",
        "they will save the country!",
    ]
);

Route[] routes =  [chitchat,politics];

RouteLayer routeLayer = new RouteLayer();
string c_target = "how are you doing?";
var c_result = routeLayer.GetRoute(c_target, routes);
// Output: chitchat
Console.WriteLine(c_result);

string p_target = "I think the president is doing a great job";
var p_result = routeLayer.GetRoute(p_target, routes);
// Output: politics
Console.WriteLine(p_result);

// run using dotnet run
// Expected output:
// chitchat
// politics

