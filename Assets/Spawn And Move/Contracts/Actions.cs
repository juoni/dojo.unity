using System;
using System.Threading.Tasks;
using Dojo;
using Dojo.Starknet;
using UnityEngine;
using dojo_bindings;
// Generated by dojo-bindgen on Tue, 16 Jan 2024 20:41:46 +0000. Do not modify this file manually.
// System definitions for `dojo_examples::actions::actions.json` contract
public class Actions : MonoBehaviour {
    // The address of this contract
    public string contractAddress;

    
    // Call the `spawn` system with the specified Account and calldata
    // Returns the transaction hash. Use `WaitForTransaction` to wait for the transaction to be confirmed.
    public async Task<FieldElement> Spawn(Account account) {
        return await account.ExecuteRaw(new dojo.Call[] {
            new dojo.Call{
                to = contractAddress,
                selector = "spawn",
                calldata = new dojo.FieldElement[] {
                    
                }
            }
        });
    }
            

    
    // Call the `move` system with the specified Account and calldata
    // Returns the transaction hash. Use `WaitForTransaction` to wait for the transaction to be confirmed.
    public async Task<FieldElement> Move(Account account, Direction direction) {
        return await account.ExecuteRaw(new dojo.Call[] {
            new dojo.Call{
                to = contractAddress,
                selector = "move",
                calldata = new dojo.FieldElement[] {
                    new FieldElement(direction).Inner
                }
            }
        });
    }
            

    
    // Call the `move_to` system with the specified Account and calldata
    // Returns the transaction hash. Use `WaitForTransaction` to wait for the transaction to be confirmed.
    public async Task<FieldElement> MoveTo(Account account, Vec2 vec) {
        return await account.ExecuteRaw(new dojo.Call[] {
            new dojo.Call{
                to = contractAddress,
                selector = "move_to",
                calldata = new dojo.FieldElement[] {
                    new FieldElement(vec.x).Inner,
                    new FieldElement(vec.y).Inner
                }
            }
        });
    }
            
}
