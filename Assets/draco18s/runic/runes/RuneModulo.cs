using Assets.draco18s.runic.init;
using Assets.draco18s.util;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.draco18s.runic.runes {
	public class RuneModulo : IExecutableRune {
		public bool Execute(Pointer pointer, ExecutionContext context) {
			object a = pointer.Pop();
			object b = pointer.Pop();
			if(a != null && b != null) {
				if(a is ValueType && b is ValueType) {
					if(MathHelper.IsInteger((ValueType)a) && MathHelper.IsInteger((ValueType)b)) {
						int c = (int)MathHelper.GetValue((ValueType)b) % (int)MathHelper.GetValue((ValueType)a);
						pointer.Push(c);
					}
					else {
						double d = MathHelper.GetValue((ValueType)a);
						if(d == 0) {
							pointer.DeductMana(pointer.GetMana());
							return true;
						}
						double c = MathHelper.GetValue((ValueType)b) % d;
						pointer.Push(c);
					}
				}
				else {

				}
			}
			return true;
		}

		public IExecutableRune Register() {
			RuneRegistry.ALL_RUNES.Add('%', this);
			return this;
		}
	}
}