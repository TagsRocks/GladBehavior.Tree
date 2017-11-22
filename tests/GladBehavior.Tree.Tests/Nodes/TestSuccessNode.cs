﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GladBehaviour.Tree;

namespace GladBehavior.Tree
{
	public sealed class TestSuccessNode : LeafTreeNode<int>
	{
		public int CalledTime { get; private set; }

		/// <inheritdoc />
		public override GladBehaviorTreeNodeState Evaluate(int context)
		{
			CalledTime++;
			return GladBehaviorTreeNodeState.Success;
		}
	}
}
