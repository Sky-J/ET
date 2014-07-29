﻿namespace BehaviorTree
{
    internal class Sequence: Node
    {
        public Sequence(Config config)
        {
            this.Name = config.Name;
        }

        public override bool Run(BlackBoard blackBoard)
        {
            foreach (var child in this.children)
            {
                if (!child.Run(blackBoard))
                {
                    return false;
                }
            }
            return true;
        }
    }
}