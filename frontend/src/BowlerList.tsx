import { useEffect, useState } from 'react';
import { Bowler } from '../src/types/Bowler';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('https://localhost:44339/bowlers');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <br />
      <div className="row">
        <h4 className="text-center">All Bowlers</h4>
      </div>
      <br />
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>First Name</th>
            <th>Middle Initial</th>
            <th>Last Name</th>
            {/* <th>Team Name</th> */}
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>ZIP Code</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((x) => (
            <tr key={x.bowlerId}>
              <td>{x.bowlerFirstName}</td>
              <td>{x.bowlerMiddleInit}</td>
              <td>{x.bowlerLastName}</td>
              <td>{x.bowlerAddress}</td>
              <td>{x.bowlerCity}</td>
              <td>{x.bowlerState}</td>
              <td>{x.bowlerZip}</td>
              <td>{x.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
