using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace MirageSDK.Examples.Scripts.ContractMessages.GameCharacterContract
{
	[Function("tokenURI", "string")]
	public class GetTokenURI : FunctionMessage
	{
		[Parameter("uint256", "_tokenId")]
		public string TokenId { get; set; }
	}
}