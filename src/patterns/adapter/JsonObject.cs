using DesignPatterns.Models;

namespace DesignPatterns.Patterns.Adapter
{
    class JsonObject : IJson
    {
        private readonly Json json;

        public static JsonObject From(Json json) {
            return new JsonObject(json);
        }

        public Json Json() {
            return json;
        }

        private JsonObject(Json json) {
            this.json = json;
        }
    }
}