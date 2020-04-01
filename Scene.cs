using System.Collections.Generic;
using System.Dynamic;

namespace OnceUponATime
{
    public class Scene
    {
        public List<Phrase> Dialogues { get; }
        public string Background { get; }
        public SceneType SceneType { get; }
    }
}