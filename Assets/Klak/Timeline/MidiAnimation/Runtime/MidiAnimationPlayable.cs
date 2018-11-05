using UnityEngine;
using UnityEngine.Playables;
using Klak.Midi;

namespace Klak.Timeline
{
    [System.Serializable]
    public class MidiAnimationPlayable : PlayableBehaviour
    {
        #region Serialized variables

        public MidiAsset sequence;

        #endregion

        #region PlayableBehaviour overrides

        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        #endregion
    }
}
