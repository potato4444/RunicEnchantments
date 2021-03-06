using Assets.draco18s.runic.init;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.draco18s.runic.runes {
	public class RuneReadString : IExecutableRune {
		public bool Execute(Pointer pointer, ExecutionContext context) {
			pointer.SetReadType(Pointer.ReadType.READ_STR);
			return true;
		}

		public IExecutableRune Register() {
			RuneRegistry.ALL_RUNES.Add('\"', this);
			return this;
		}
	}
}