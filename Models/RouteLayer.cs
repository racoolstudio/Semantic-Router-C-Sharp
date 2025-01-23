using SmartComponents.Inference;
using SmartComponents.LocalEmbeddings;


namespace SemanticRouter.Models
{
    public class RouteLayer
    {
        private readonly LocalEmbedder embedder = new LocalEmbedder();

        public string GetRoute(string target, Route[] routes)
        {
            var candidates = routes.SelectMany(route =>
                   route.Utterances.Select(utterance =>
                       (route, embedder.Embed(utterance))) // Embed each utterance
               );

            SimilarityQuery query = new SimilarityQuery()
            {
                SearchText = target,
                MaxResults = 1
            };

            var closestRoutes = embedder.FindClosest(query, candidates);

            var highestMatchingRoute = closestRoutes.FirstOrDefault();

            // Return a meaningful result
            if (highestMatchingRoute != null)
            {
                return highestMatchingRoute.Name;  // Assuming each route has a Name property
            }

            return "No match found";
        }
    }

    public class Route
    {
        public String Name { get; set; }
        public List<String> Utterances { get; set; }

        public Route(String name, List<String> utterances)
        {
            Name = name;
            Utterances = utterances;
        }
    }
}
