use std::env::args;
use std::io::Write;
use std::process::exit;

fn help_die(exe: &str) -> ! {
    eprintln!("{exe} {{configPath}} {{outputPath}}");
    exit(1)
}

fn main() {
    env_logger::init();
    let mut args = args();
    let exe = args.next().unwrap();
    let config_path = args.next().unwrap_or_else(|| help_die(&exe));
    let output_path = args.next().unwrap_or_else(|| help_die(&exe));

    let json = std::fs::read_to_string(config_path).expect("reading json");
    let minified = minify::json::minify(&json);

    let mut output = std::fs::File::create(output_path).expect("creating output");

    vpai_creator::create_unitypackage(&mut output, minified.as_bytes())
        .expect("creating unity package");

    output.flush().expect("creating unity package");
}
