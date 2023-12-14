import MainPage from "@/app/page";
import Search from "@/components/users/search";
import Person from "@/components/users/person";
import AddPerson from "@/components/users/add-person";



export function ChangeState() {

}

export default function Users() {
    return (
        <div className={ " bg-white"}>
            <div className={ "users pb-6"}>
                <div className={"self-container"}>
                    <Search/>
                    <div className={"grid grid-cols-2 gap-2.5"}>
                        <Person/>
                        <Person/>
                        <Person/>
                        <AddPerson/>
                    </div>

                </div>
            </div>
        </div>
    )
}