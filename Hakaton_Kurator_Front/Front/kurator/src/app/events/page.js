import MainPage from "@/app/page";
import "../../css/events.css"
import Event from "@/components/events/event";
import SearchEvents from "@/components/events/search-events";

export function ChangeState() {

}

export default function Users() {
    return (
        <div className={ " bg-white"}>
            <div className={ "users pb-6"}>
                <div className={"self-container"}>
                    <SearchEvents/>
                    <div className={""}>
                        <Event/>
                        <Event/>
                    </div>
                </div>
            </div>
        </div>
    )
}