using System;
using System.Linq;

namespace Project.model {


	public static partial class LetterFlyweight {

		private abstract class AbstractLetter : Letter {
			private BonusAlgorithm bonusAlgorithm;

			public AbstractLetter(BonusAlgorithm bonusAlgorithm) {
				#region Preconditions
				if (bonusAlgorithm == null)
					throw (new ArgumentException("BonusAlgorithm null!"));
				#endregion

				this.bonusAlgorithm = bonusAlgorithm;
			}

			public abstract char Character { get; }

			public abstract int BaseScore { get; }

			public BonusAlgorithm BonusAlgorithm {
				get {
					return (bonusAlgorithm);
				}
				set {
					#region Preconditions
					if (value == null)
						throw (new ArgumentException("BonusAlgorithm null!"));
					#endregion

					bonusAlgorithm = value;
				}
			}
	
			public int GetScore(char charBonus) {
				#region Preconditions
				if (!All.Contains(charBonus))
					throw (new ArgumentException("Invalid bonus character!"));
				#endregion

				if ( Character == charBonus )
					return (BonusAlgorithm.CalculateBonus(BaseScore));
				return (BaseScore);
			}
		}

		#region Letters

		private class A : AbstractLetter {

			public A(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('a');
				}
			}

			public override int BaseScore {
				get {
					return (1);
				}
			}
		}

		private class B : AbstractLetter {

			public B(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('b');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class C : AbstractLetter {

			public C(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('c');
				}
			}

			public override int BaseScore {
				get {
					return (4);
				}
			}
		}

		private class D : AbstractLetter {

			public D(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('d');
				}
			}

			public override int BaseScore {
				get {
					return (5);
				}
			}
		}

		private class E : AbstractLetter {

			public E(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('e');
				}
			}

			public override int BaseScore {
				get {
					return (1);
				}
			}
		}

		private class F : AbstractLetter {

			public F(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('f');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class G : AbstractLetter {

			public G(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('g');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class H : AbstractLetter {

			public H(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('h');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class I : AbstractLetter {

			public I(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('i');
				}
			}

			public override int BaseScore {
				get {
					return (1);
				}
			}
		}

		private class J : AbstractLetter {

			public J(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('j');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class K : AbstractLetter {

			public K(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('k');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class L : AbstractLetter {

			public L(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('l');
				}
			}

			public override int BaseScore {
				get {
					return (3);
				}
			}
		}

		private class M : AbstractLetter {

			public M(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('m');
				}
			}

			public override int BaseScore {
				get {
					return (5);
				}
			}
		}

		private class N : AbstractLetter {

			public N(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('n');
				}
			}

			public override int BaseScore {
				get {
					return (3);
				}
			}
		}

		private class O : AbstractLetter {

			public O(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('o');
				}
			}

			public override int BaseScore {
				get {
					return (2);
				}
			}
		}

		private class P : AbstractLetter {

			public P(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('p');
				}
			}

			public override int BaseScore {
				get {
					return (5);
				}
			}
		}

		private class Q : AbstractLetter {

			public Q(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('q');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class R : AbstractLetter {

			public R(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('r');
				}
			}

			public override int BaseScore {
				get {
					return (3);
				}
			}
		}

		private class S : AbstractLetter {

			public S(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('s');
				}
			}

			public override int BaseScore {
				get {
					return (4);
				}
			}
		}

		private class T : AbstractLetter {

			public T(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('t');
				}
			}

			public override int BaseScore {
				get {
					return (4);
				}
			}
		}

		private class U : AbstractLetter {

			public U(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('u');
				}
			}

			public override int BaseScore {
				get {
					return (5);
				}
			}
		}

		private class V : AbstractLetter {

			public V(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('v');
				}
			}

			public override int BaseScore {
				get {
					return (5);
				}
			}
		}

		private class W : AbstractLetter {

			public W(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('w');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class X : AbstractLetter {

			public X(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('x');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class Y : AbstractLetter {

			public Y(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('y');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		private class Z : AbstractLetter {

			public Z(BonusAlgorithm bonusAlgorithm) : base(bonusAlgorithm) { }

			public override char Character {
				get {
					return ('z');
				}
			}

			public override int BaseScore {
				get {
					return (6);
				}
			}
		}

		#endregion

	}


}
