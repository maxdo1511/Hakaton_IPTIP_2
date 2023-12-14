import MainPage from "@/app/page";
import SearchReit from "@/components/materials/search-material";
import Course from "@/components/materials/course";
import "../../css/materials.css"

export function ChangeState() {

}

export default function Users() {
    return (
        <div className={ " bg-white"}>
            <div className={ "users pb-6"}>
                <div className={"self-container"}>
                    <SearchReit/>
                    <div className={"grid grid-cols-3 gap-7"}>
                        <Course/>
                        <Course/>
                        <Course/>
                        <Course/>
                    </div>
                </div>
            </div>
        </div>
    )
}