import { Grid } from "semantic-ui-react";
import GoalSeekForm from "./goalSeek/form/GoalSeekForm";
import { GoalSeek } from "../../models/goalSeek";

interface Props {
    goalSeek: GoalSeek | undefined;
    create: (goalSeek: GoalSeek) => void;
}

export default function GoalSeekDashboard(props: Props) {
    return (
        <Grid.Column width='5' style={{marginTop:'-20em', marginLeft:'50em'}}>
            <GoalSeekForm goalSeek={props.goalSeek} create={props.create} />
        </Grid.Column>
    )
}